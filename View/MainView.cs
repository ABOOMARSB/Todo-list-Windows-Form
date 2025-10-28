using System;
using System.Drawing;
using System.Windows.Forms;
using PraktijkOpdracht.View;

namespace PraktijkOpdracht
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnToList.Parent = pictureBox1;
            btnToList.BackColor = Color.Transparent;
        }

        private void btnToList_Click(object sender, EventArgs e)
        {
            Hide();
            ToDoView ToDoView = new ToDoView();
            ToDoView.ShowDialog();
            Close();
        }
    }
}
