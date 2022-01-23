
namespace QLCBH6_RESTFul
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Jatekok_Grid = new System.Windows.Forms.DataGridView();
            this.Jatekok_POST = new System.Windows.Forms.Button();
            this.Jatekok_PUT = new System.Windows.Forms.Button();
            this.Jatekok_DELETE = new System.Windows.Forms.Button();
            this.Jatekok_ID = new System.Windows.Forms.TextBox();
            this.Jatekok_NEV = new System.Windows.Forms.TextBox();
            this.Jatekok_MUFAJ = new System.Windows.Forms.TextBox();
            this.Jatekok_KIADO = new System.Windows.Forms.TextBox();
            this.Jatekok_JATEKMOD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PHPGRID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Jatekok_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Jatekok_Grid
            // 
            this.Jatekok_Grid.BackgroundColor = System.Drawing.Color.Tan;
            this.Jatekok_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Jatekok_Grid.Location = new System.Drawing.Point(12, 12);
            this.Jatekok_Grid.Name = "Jatekok_Grid";
            this.Jatekok_Grid.RowTemplate.Height = 25;
            this.Jatekok_Grid.Size = new System.Drawing.Size(535, 569);
            this.Jatekok_Grid.TabIndex = 0;
            this.Jatekok_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Jatekok_Grid_CellClick);
            // 
            // Jatekok_POST
            // 
            this.Jatekok_POST.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jatekok_POST.Location = new System.Drawing.Point(643, 324);
            this.Jatekok_POST.Name = "Jatekok_POST";
            this.Jatekok_POST.Size = new System.Drawing.Size(116, 41);
            this.Jatekok_POST.TabIndex = 1;
            this.Jatekok_POST.Text = "Hozzáad";
            this.Jatekok_POST.UseVisualStyleBackColor = true;
            this.Jatekok_POST.Click += new System.EventHandler(this.Jatekok_POST_Click);
            // 
            // Jatekok_PUT
            // 
            this.Jatekok_PUT.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jatekok_PUT.Location = new System.Drawing.Point(643, 371);
            this.Jatekok_PUT.Name = "Jatekok_PUT";
            this.Jatekok_PUT.Size = new System.Drawing.Size(116, 41);
            this.Jatekok_PUT.TabIndex = 2;
            this.Jatekok_PUT.Text = "Módosít";
            this.Jatekok_PUT.UseVisualStyleBackColor = true;
            this.Jatekok_PUT.Click += new System.EventHandler(this.Jatekok_PUT_Click);
            // 
            // Jatekok_DELETE
            // 
            this.Jatekok_DELETE.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jatekok_DELETE.Location = new System.Drawing.Point(643, 418);
            this.Jatekok_DELETE.Name = "Jatekok_DELETE";
            this.Jatekok_DELETE.Size = new System.Drawing.Size(116, 41);
            this.Jatekok_DELETE.TabIndex = 3;
            this.Jatekok_DELETE.Text = "Töröl";
            this.Jatekok_DELETE.UseVisualStyleBackColor = true;
            this.Jatekok_DELETE.Click += new System.EventHandler(this.Jatekok_DELETE_Click);
            // 
            // Jatekok_ID
            // 
            this.Jatekok_ID.Location = new System.Drawing.Point(643, 53);
            this.Jatekok_ID.Name = "Jatekok_ID";
            this.Jatekok_ID.Size = new System.Drawing.Size(114, 23);
            this.Jatekok_ID.TabIndex = 4;
            // 
            // Jatekok_NEV
            // 
            this.Jatekok_NEV.Location = new System.Drawing.Point(643, 105);
            this.Jatekok_NEV.Name = "Jatekok_NEV";
            this.Jatekok_NEV.Size = new System.Drawing.Size(153, 23);
            this.Jatekok_NEV.TabIndex = 5;
            // 
            // Jatekok_MUFAJ
            // 
            this.Jatekok_MUFAJ.Location = new System.Drawing.Point(643, 155);
            this.Jatekok_MUFAJ.Name = "Jatekok_MUFAJ";
            this.Jatekok_MUFAJ.Size = new System.Drawing.Size(114, 23);
            this.Jatekok_MUFAJ.TabIndex = 6;
            // 
            // Jatekok_KIADO
            // 
            this.Jatekok_KIADO.Location = new System.Drawing.Point(643, 200);
            this.Jatekok_KIADO.Name = "Jatekok_KIADO";
            this.Jatekok_KIADO.Size = new System.Drawing.Size(114, 23);
            this.Jatekok_KIADO.TabIndex = 7;
            // 
            // Jatekok_JATEKMOD
            // 
            this.Jatekok_JATEKMOD.Location = new System.Drawing.Point(643, 252);
            this.Jatekok_JATEKMOD.Name = "Jatekok_JATEKMOD";
            this.Jatekok_JATEKMOD.Size = new System.Drawing.Size(114, 23);
            this.Jatekok_JATEKMOD.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(643, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(643, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(643, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Műfaj:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(643, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kiadó:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(643, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Játékmód:";
            // 
            // PHPGRID
            // 
            this.PHPGRID.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PHPGRID.Location = new System.Drawing.Point(617, 501);
            this.PHPGRID.Name = "PHPGRID";
            this.PHPGRID.Size = new System.Drawing.Size(167, 69);
            this.PHPGRID.TabIndex = 14;
            this.PHPGRID.Text = "PHP Grid";
            this.PHPGRID.UseVisualStyleBackColor = true;
            this.PHPGRID.Click += new System.EventHandler(this.PHPGRID_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(849, 593);
            this.Controls.Add(this.PHPGRID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Jatekok_JATEKMOD);
            this.Controls.Add(this.Jatekok_KIADO);
            this.Controls.Add(this.Jatekok_MUFAJ);
            this.Controls.Add(this.Jatekok_NEV);
            this.Controls.Add(this.Jatekok_ID);
            this.Controls.Add(this.Jatekok_DELETE);
            this.Controls.Add(this.Jatekok_PUT);
            this.Controls.Add(this.Jatekok_POST);
            this.Controls.Add(this.Jatekok_Grid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Jatekok_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Jatekok_Grid;
        private System.Windows.Forms.Button Jatekok_POST;
        private System.Windows.Forms.Button Jatekok_PUT;
        private System.Windows.Forms.Button Jatekok_DELETE;
        private System.Windows.Forms.TextBox Jatekok_ID;
        private System.Windows.Forms.TextBox Jatekok_NEV;
        private System.Windows.Forms.TextBox Jatekok_MUFAJ;
        private System.Windows.Forms.TextBox Jatekok_KIADO;
        private System.Windows.Forms.TextBox Jatekok_JATEKMOD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PHPGRID;
    }
}

