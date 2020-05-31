namespace sidehelp
{
    partial class frmInput
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
            this.rdbtnTexas = new System.Windows.Forms.RadioButton();
            this.rdbtnAmerica = new System.Windows.Forms.RadioButton();
            this.rdbtnTurkey = new System.Windows.Forms.RadioButton();
            this.rdbtnUK = new System.Windows.Forms.RadioButton();
            this.rdbtnGreece = new System.Windows.Forms.RadioButton();
            this.grpFlags = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFlags.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtnTexas
            // 
            this.rdbtnTexas.AutoSize = true;
            this.rdbtnTexas.Location = new System.Drawing.Point(28, 43);
            this.rdbtnTexas.Name = "rdbtnTexas";
            this.rdbtnTexas.Size = new System.Drawing.Size(95, 31);
            this.rdbtnTexas.TabIndex = 0;
            this.rdbtnTexas.TabStop = true;
            this.rdbtnTexas.Text = "Texas";
            this.rdbtnTexas.UseVisualStyleBackColor = true;
            // 
            // rdbtnAmerica
            // 
            this.rdbtnAmerica.AutoSize = true;
            this.rdbtnAmerica.Location = new System.Drawing.Point(28, 83);
            this.rdbtnAmerica.Name = "rdbtnAmerica";
            this.rdbtnAmerica.Size = new System.Drawing.Size(115, 31);
            this.rdbtnAmerica.TabIndex = 1;
            this.rdbtnAmerica.TabStop = true;
            this.rdbtnAmerica.Text = "America";
            this.rdbtnAmerica.UseVisualStyleBackColor = true;
            // 
            // rdbtnTurkey
            // 
            this.rdbtnTurkey.AutoSize = true;
            this.rdbtnTurkey.Location = new System.Drawing.Point(28, 124);
            this.rdbtnTurkey.Name = "rdbtnTurkey";
            this.rdbtnTurkey.Size = new System.Drawing.Size(104, 31);
            this.rdbtnTurkey.TabIndex = 2;
            this.rdbtnTurkey.TabStop = true;
            this.rdbtnTurkey.Text = "Turkey";
            this.rdbtnTurkey.UseVisualStyleBackColor = true;
            // 
            // rdbtnUK
            // 
            this.rdbtnUK.AutoSize = true;
            this.rdbtnUK.Location = new System.Drawing.Point(28, 164);
            this.rdbtnUK.Name = "rdbtnUK";
            this.rdbtnUK.Size = new System.Drawing.Size(190, 31);
            this.rdbtnUK.TabIndex = 3;
            this.rdbtnUK.TabStop = true;
            this.rdbtnUK.Text = "United Kingdom";
            this.rdbtnUK.UseVisualStyleBackColor = true;
            // 
            // rdbtnGreece
            // 
            this.rdbtnGreece.AutoSize = true;
            this.rdbtnGreece.Location = new System.Drawing.Point(28, 205);
            this.rdbtnGreece.Name = "rdbtnGreece";
            this.rdbtnGreece.Size = new System.Drawing.Size(106, 31);
            this.rdbtnGreece.TabIndex = 4;
            this.rdbtnGreece.TabStop = true;
            this.rdbtnGreece.Text = "Greece";
            this.rdbtnGreece.UseVisualStyleBackColor = true;
            // 
            // grpFlags
            // 
            this.grpFlags.Controls.Add(this.rdbtnTexas);
            this.grpFlags.Controls.Add(this.rdbtnGreece);
            this.grpFlags.Controls.Add(this.rdbtnAmerica);
            this.grpFlags.Controls.Add(this.rdbtnUK);
            this.grpFlags.Controls.Add(this.rdbtnTurkey);
            this.grpFlags.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFlags.Location = new System.Drawing.Point(28, 100);
            this.grpFlags.Name = "grpFlags";
            this.grpFlags.Size = new System.Drawing.Size(236, 256);
            this.grpFlags.TabIndex = 5;
            this.grpFlags.TabStop = false;
            this.grpFlags.Text = "Flags";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(313, 165);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(85, 36);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(313, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 36);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Which flag would you like to see?";
            // 
            // frmInput
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(445, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.grpFlags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInput";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose a Flag";
            this.grpFlags.ResumeLayout(false);
            this.grpFlags.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnTexas;
        private System.Windows.Forms.RadioButton rdbtnAmerica;
        private System.Windows.Forms.RadioButton rdbtnTurkey;
        private System.Windows.Forms.RadioButton rdbtnUK;
        private System.Windows.Forms.RadioButton rdbtnGreece;
        private System.Windows.Forms.GroupBox grpFlags;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}