namespace TextFileManipulation
{
    public partial class Form1_TextFile : Form
    {
        private string TextFilePath = @"./data/sensor.txt";

        public Form1_TextFile()
        {
            InitializeComponent();
        }

        private void Form1_TextFile_Load(object sender, EventArgs e)
        {
            // Update the file paths
            labelFilePathWrite.Text = $"File Path (W): {TextFilePath}";
            labelFilePathRead.Text  = $"File Path (R): {TextFilePath}";
        }

        /**
         * Write Button
         */
        private void buttonWrite_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(TextFilePath))
            {
                // Write timestamp
                //sw.WriteLine(DateTime.Now.ToString());

                // Write text
                sw.WriteLine(richTextBoxWrite.Text);
            }
        }

        /**
         * Append Button
         */ 
        private void buttonAppend_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(TextFilePath))
            {
                // Write timestamp
                //sw.WriteLine(DateTime.Now.ToString());

                // Write text
                sw.WriteLine(richTextBoxWrite.Text);
            }
        }

        /**
         * Read Button
         */ 
        private void buttonRead_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(TextFilePath))
            {
                string? line; // line can be null

                // Clear the previous content
                richTextBoxRead.Clear();

                // Read and append all lines
                while ( (line = sr.ReadLine()) != null)
                {
                    richTextBoxRead.AppendText($"{line}\n");
                }

                // Move the scrollbar to the end
                richTextBoxRead.SelectionStart = richTextBoxRead.Text.Length;
                richTextBoxRead.ScrollToCaret();
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(TextFilePath))
            {
                string? line;
                int lineCount = 0;
                int charCount = 0;
                string newText = "";
                while ((line = sr.ReadLine()) != null)
                {
                    lineCount += 1;
                    charCount += line.Length;
                    newText   += $"{line.ToUpper()}\n";
                }
                richTextBoxRead.Text = newText;
                richTextBoxRead.AppendText($"#lines: {lineCount}\n");
                richTextBoxRead.AppendText($"#chars: {charCount}\n");
            }
        }
    }
}