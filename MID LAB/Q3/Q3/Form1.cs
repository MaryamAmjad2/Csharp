﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = "Maryam,";
            string lastName = "Amjad";

            if (firstName.Length < 1 || lastName.Length < 1)
            {
                MessageBox.Show("Please enter your first and last name.");
                return;
            }

            // Create a StringBuilder to build the password
            StringBuilder password = new StringBuilder();

            // Add initials of first and last name
            password.Append(char.ToUpper(firstName[0]));
            password.Append(firstName.Substring(1));
            password.Append(char.ToUpper(lastName[0]));
            password.Append(lastName.Substring(1)); 
            

            // Generate random uppercase alphabet
            Random random = new Random();
            //password.Append((char)random.Next('A', 'Z' + 1));

            // Generate 4 random numbers
            for (int i = 0; i < 2; i++)
            {
                password.Append((char)random.Next('0', '0' + 1)); // Append '0'
            }

            for (int i = 0; i < 2; i++)
            {
                password.Append((char)random.Next('9', '9' + 1)); // Append '9'
            }

            // Generate 2 more random numbers between '0' and '9' (excluding 0 and 9)
            for (int i = 0; i < 2; i++)
            {
                password.Append((char)random.Next('1', '8' + 1));
            }

            // Generate 2 special characters
            string specialCharacters = "!@#$%^&*()_-+=<>?";
            for (int i = 0; i < 2; i++)
            {
                password.Append(specialCharacters[random.Next(specialCharacters.Length)]);
            }

            // Shuffle the password characters for better security
            password = ShuffleString(password);

            // Limit the password to a maximum length of 20
            if (password.Length > 20)
            {
                password.Length = 20;
            }

            // Display the generated password
            label1.Text = password.ToString();
        }
        private StringBuilder ShuffleString(StringBuilder str)
        {
            Random random = new Random();
            int n = str.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                char value = str[k];
                str[k] = str[n];
                str[n] = value;
            }
            return str;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

    }
    }

