namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
        {
            MessageBox.Show("Please enter a username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Hide();

        using (var programForm = new ProgramForm())
        {
            programForm.ShowDialog(this);
        }

        Show();
    }
}
