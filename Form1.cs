using Microsoft.Win32;

namespace TASK_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            object om = Registry.CurrentUser.OpenSubKey(@"SoftWare\Test");
            if (Registry.CurrentUser.OpenSubKey("Software").GetSubKeyNames().Contains("Test"))
            {
                if (Registry.CurrentUser.OpenSubKey(@"Software\Test")
                    .GetValueNames().Contains("FormText"))
                {
                    textBox1.Text = Registry.CurrentUser.OpenSubKey(@"Software\Test")
                        .GetValue("FormText").ToString();
                }
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textbox1_LostFocus(object sender, EventArgs e)
        {
            if (!Registry.CurrentUser.OpenSubKey("Software")
                .GetSubKeyNames().Contains("Text"))
            {
                Registry.CurrentUser.CreateSubKey(@"Software\Test");
            }
            // Открываем регистр и записывает текст в value - FormText
            Registry.CurrentUser.OpenSubKey(@"Software\Test", true)
                .SetValue("FormText", textBox1.Text);
        }

        private void button1_click(object sender, EventArgs e)
        {
            if (Registry.CurrentUser.OpenSubKey("Software")
                    .GetSubKeyNames().Contains("Text"))
            {
                Registry.CurrentUser.OpenSubKey(@"Software\Test", true)
                    .DeleteValue("FormText");
            }

            textBox1.Text = "";
        }
    }
}
