
namespace Ligma
{
    partial class Ligma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ligma));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(631, 279);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 99);
            this.button1.TabIndex = 1;
            this.button1.Text = "EXE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(629, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 93);
            this.button3.TabIndex = 3;
            this.button3.Text = "INJECT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.SystemColors.Menu;
            this.Output.FormattingEnabled = true;
            this.Output.Location = new System.Drawing.Point(0, 279);
            this.Output.Name = "Output";
            this.Output.ScrollAlwaysVisible = true;
            this.Output.Size = new System.Drawing.Size(693, 108);
            this.Output.TabIndex = 4;
            // 
            // Ligma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 386);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ligma";
            this.Text = "Ligma";
            this.Load += new System.EventHandler(this.Ligma_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ligma_FormClosed);
            this.ResumeLayout(false);

        }

        private void Ligma_FormClosed1(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox Output;
    }
}

