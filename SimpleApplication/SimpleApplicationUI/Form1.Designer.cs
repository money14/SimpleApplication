namespace SimpleApplicationUI
{
    partial class headerText
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
            this.header = new System.Windows.Forms.Label();
            this.ItemsListBoxLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.addToCart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.header.Location = new System.Drawing.Point(9, 18);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(405, 37);
            this.header.TabIndex = 0;
            this.header.Text = "Consignment Shop Demo";
            // 
            // ItemsListBoxLabel
            // 
            this.ItemsListBoxLabel.AutoSize = true;
            this.ItemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ItemsListBoxLabel.Location = new System.Drawing.Point(37, 80);
            this.ItemsListBoxLabel.Name = "ItemsListBoxLabel";
            this.ItemsListBoxLabel.Size = new System.Drawing.Size(103, 20);
            this.ItemsListBoxLabel.TabIndex = 1;
            this.ItemsListBoxLabel.Text = "Store Items";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(37, 103);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(314, 277);
            this.itemsListBox.TabIndex = 2;
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(357, 223);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(133, 38);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add to Cart -->";
            this.addToCart.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(496, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 277);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(496, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Store Items";
            // 
            // headerText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 479);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.ItemsListBoxLabel);
            this.Controls.Add(this.header);
            this.Name = "headerText";
            this.Text = "Consignment Shop Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label ItemsListBoxLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

