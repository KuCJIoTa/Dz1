using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дз1
{
    public partial class Form1 : Form
    {
        private int secretNumber;
        private int attempts;
        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }
        private void StartNewGame()
        {
            Random random = new Random();
            secretNumber = random.Next(1, 101);
            attempts = 0;
            lblMessage.Text = "Угадайте число от 1 до 100";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

