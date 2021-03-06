﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tableLogin = new System.Windows.Forms.TableLayoutPanel();
            this.textWelcome = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.tableLayoutForm = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutColor = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tableLogin.SuspendLayout();
            this.tableLayoutForm.SuspendLayout();
            this.tableLayoutColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLogin
            // 
            this.tableLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLogin.AutoSize = true;
            this.tableLogin.BackColor = System.Drawing.Color.White;
            this.tableLogin.ColumnCount = 6;
            this.tableLayoutForm.SetColumnSpan(this.tableLogin, 3);
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLogin.Controls.Add(this.textWelcome, 1, 1);
            this.tableLogin.Controls.Add(this.labelLogin, 1, 4);
            this.tableLogin.Controls.Add(this.textBoxLogin, 1, 5);
            this.tableLogin.Controls.Add(this.labelPassword, 1, 7);
            this.tableLogin.Controls.Add(this.textBoxPassword, 1, 8);
            this.tableLogin.Controls.Add(this.showPassword, 2, 10);
            this.tableLogin.Controls.Add(this.buttonLogIn, 2, 11);
            this.tableLogin.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLogin.Location = new System.Drawing.Point(160, 75);
            this.tableLogin.Margin = new System.Windows.Forms.Padding(0);
            this.tableLogin.Name = "tableLogin";
            this.tableLogin.RowCount = 14;
            this.tableLayoutForm.SetRowSpan(this.tableLogin, 4);
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142856F));
            this.tableLogin.Size = new System.Drawing.Size(480, 300);
            this.tableLogin.TabIndex = 0;
            this.tableLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textWelcome
            // 
            this.textWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textWelcome.AutoSize = true;
            this.tableLogin.SetColumnSpan(this.textWelcome, 4);
            this.textWelcome.Font = new System.Drawing.Font("Gotham Medium", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWelcome.ForeColor = System.Drawing.Color.Black;
            this.textWelcome.Location = new System.Drawing.Point(79, 21);
            this.textWelcome.Margin = new System.Windows.Forms.Padding(0);
            this.textWelcome.Name = "textWelcome";
            this.tableLogin.SetRowSpan(this.textWelcome, 2);
            this.textWelcome.Size = new System.Drawing.Size(316, 42);
            this.textWelcome.TabIndex = 5;
            this.textWelcome.Text = "Welcome.";
            this.textWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLogin.SetColumnSpan(this.labelLogin, 4);
            this.labelLogin.Font = new System.Drawing.Font("Gotham Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.Black;
            this.labelLogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelLogin.Location = new System.Drawing.Point(79, 84);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(316, 21);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Login:";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLogin.SetColumnSpan(this.textBoxLogin, 4);
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(79, 105);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(316, 27);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Text = "Please enter your login";
            this.textBoxLogin.Click += new System.EventHandler(this.textBoxLogin_Clicked);
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_Enter);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLogin.SetColumnSpan(this.labelPassword, 4);
            this.labelPassword.Font = new System.Drawing.Font("Gotham Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Black;
            this.labelPassword.Location = new System.Drawing.Point(79, 147);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(316, 21);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLogin.SetColumnSpan(this.textBoxPassword, 4);
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.textBoxPassword.Location = new System.Drawing.Point(79, 168);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(316, 27);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "Please enter your password";
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Clicked);
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_Enter);
            // 
            // showPassword
            // 
            this.showPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showPassword.AutoSize = true;
            this.tableLogin.SetColumnSpan(this.showPassword, 2);
            this.showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassword.Font = new System.Drawing.Font("Gotham Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.ForeColor = System.Drawing.Color.Black;
            this.showPassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showPassword.Location = new System.Drawing.Point(158, 210);
            this.showPassword.Margin = new System.Windows.Forms.Padding(0);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(158, 21);
            this.showPassword.TabIndex = 3;
            this.showPassword.Text = "Show password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLogin.SetColumnSpan(this.buttonLogIn, 2);
            this.buttonLogIn.FlatAppearance.BorderSize = 0;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Gotham Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.Black;
            this.buttonLogIn.Location = new System.Drawing.Point(158, 231);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogIn.Name = "buttonLogIn";
            this.tableLogin.SetRowSpan(this.buttonLogIn, 2);
            this.buttonLogIn.Size = new System.Drawing.Size(158, 42);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "Login";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Visible = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // tableLayoutForm
            // 
            this.tableLayoutForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutForm.BackColor = System.Drawing.Color.Crimson;
            this.tableLayoutForm.ColumnCount = 5;
            this.tableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutForm.Controls.Add(this.tableLogin, 1, 1);
            this.tableLayoutForm.Controls.Add(this.tableLayoutColor, 4, 0);
            this.tableLayoutForm.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutForm.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutForm.Name = "tableLayoutForm";
            this.tableLayoutForm.RowCount = 6;
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutForm.Size = new System.Drawing.Size(800, 455);
            this.tableLayoutForm.TabIndex = 8;
            // 
            // tableLayoutColor
            // 
            this.tableLayoutColor.ColumnCount = 2;
            this.tableLayoutColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutColor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutColor.Controls.Add(this.textBoxColor, 0, 1);
            this.tableLayoutColor.Controls.Add(this.buttonChangeColor, 1, 1);
            this.tableLayoutColor.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutColor.Location = new System.Drawing.Point(643, 3);
            this.tableLayoutColor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.tableLayoutColor.Name = "tableLayoutColor";
            this.tableLayoutColor.RowCount = 2;
            this.tableLayoutColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutColor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutColor.Size = new System.Drawing.Size(154, 47);
            this.tableLayoutColor.TabIndex = 1;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColor.Location = new System.Drawing.Point(3, 26);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(117, 20);
            this.textBoxColor.TabIndex = 9;
            this.textBoxColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_Enter);
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonChangeColor.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonChangeColor.Location = new System.Drawing.Point(123, 25);
            this.buttonChangeColor.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(31, 22);
            this.buttonChangeColor.TabIndex = 10;
            this.buttonChangeColor.Text = "u";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.Location = new System.Drawing.Point(30, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 23);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Color?";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tableLogin.ResumeLayout(false);
            this.tableLogin.PerformLayout();
            this.tableLayoutForm.ResumeLayout(false);
            this.tableLayoutForm.PerformLayout();
            this.tableLayoutColor.ResumeLayout(false);
            this.tableLayoutColor.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label textWelcome;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutColor;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

