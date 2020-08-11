using System;
using System.IO;
using System.Windows.Forms;

namespace fileParserTest
{
    public partial class Form1 : Form
    {
        private string inputFilePath = "";
        private string outputFilePath = "";
        private bool shouldPunctuationBeRemoved = false;
        private uint minWordLength = 5;
        public Form1()
        {
            InitializeComponent();
            filepathLabel.Text = "";
            outputFilepathLabel.Text = "";
            wordLengthInput.Value = minWordLength;
            cleanPunctuationCheckbox.Checked = shouldPunctuationBeRemoved;
            successLabel.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            shouldPunctuationBeRemoved = cleanPunctuationCheckbox.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            minWordLength = Decimal.ToUInt32(wordLengthInput.Value);
        }

        private void wordLengthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFilePath = openFileDialog.FileName;
                    filepathLabel.Text = inputFilePath;
                }
            }
        }

        private void chooseFileButtonWrite_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFilePath = openFileDialog.FileName;
                    outputFilepathLabel.Text = outputFilePath;
                }
            }
        }

        private void ToggleInputs(bool value)
        {
            chooseFileButton.Enabled = value;
            chooseFileButtonWrite.Enabled = value;
            cleanPunctuationCheckbox.Enabled = value;
            wordLengthInput.Enabled = value;
            startButton.Enabled = value;
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            successLabel.Text = "";

            if (inputFilePath.Equals(""))
            {
                MessageBox.Show("Необходимо выбрать файл для обработки.", "Ошибка", default, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(inputFilePath))
            {
                MessageBox.Show("Указанный файл для обработки не существует.", "Ошибка", default, MessageBoxIcon.Error);
                return;
            }

            if (outputFilePath.Equals(""))
            {
                MessageBox.Show("Необходимо выбрать файл для записи результатов обработки.", "Ошибка", default, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(outputFilePath))
            {
                MessageBox.Show("Указанный файл для записи результатов обработки не существует.", "Ошибка", default, MessageBoxIcon.Error);
                return;
            }

            ToggleInputs(false);

            try
            {
                InputOutputFileHandler parser = new InputOutputFileHandler(minWordLength, shouldPunctuationBeRemoved);
                parser.FileOpened += parser_FileOpened;
                parser.BlockParsed += parser_LineParsed;

                if (await parser.Handle(inputFilePath, outputFilePath))
                {
                    successLabel.Text = "Завершено";
                    ToggleInputs(true);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", default, MessageBoxIcon.Error);
                ToggleInputs(true);
            }
        }

        private void parser_FileOpened(object parser, FileOpenedEventArgs args)
        {
            progressBar.Maximum = args.fileSize;
        }

        private void parser_LineParsed(object parser, BlockParsedEventArgs args)
        {
            progressBar.Step = args.lineSize;
            progressBar.PerformStep();
        }
    }
}
