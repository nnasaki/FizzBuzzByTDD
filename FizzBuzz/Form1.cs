using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        private FizzBuzzer fizzBuzzer = new FizzBuzzer();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            ShowFizzBuzz();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowFizzBuzz();
        }

        private void ShowFizzBuzz()
        {
            this.Label1.Text = this.fizzBuzzer.SayNext();
        }


    }
}
