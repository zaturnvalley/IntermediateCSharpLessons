﻿namespace ConsignmentShopUI
{
	partial class ConsignmentShop
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
			this.headerText = new System.Windows.Forms.Label();
			this.itemsListBox = new System.Windows.Forms.ListBox();
			this.itemsListBoxLabel = new System.Windows.Forms.Label();
			this.addToCart = new System.Windows.Forms.Button();
			this.shoppingCartListBoxLabel = new System.Windows.Forms.Label();
			this.shoppingCartListBox = new System.Windows.Forms.ListBox();
			this.makePurchase = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// headerText
			// 
			this.headerText.AutoSize = true;
			this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerText.Location = new System.Drawing.Point(11, 29);
			this.headerText.Name = "headerText";
			this.headerText.Size = new System.Drawing.Size(405, 37);
			this.headerText.TabIndex = 0;
			this.headerText.Text = "Consignment Shop Demo";
			this.headerText.Click += new System.EventHandler(this.label1_Click);
			// 
			// itemsListBox
			// 
			this.itemsListBox.FormattingEnabled = true;
			this.itemsListBox.ItemHeight = 20;
			this.itemsListBox.Location = new System.Drawing.Point(18, 106);
			this.itemsListBox.Name = "itemsListBox";
			this.itemsListBox.Size = new System.Drawing.Size(312, 264);
			this.itemsListBox.TabIndex = 1;
			this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
			// 
			// itemsListBoxLabel
			// 
			this.itemsListBoxLabel.AutoSize = true;
			this.itemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.itemsListBoxLabel.Location = new System.Drawing.Point(14, 83);
			this.itemsListBoxLabel.Name = "itemsListBoxLabel";
			this.itemsListBoxLabel.Size = new System.Drawing.Size(103, 20);
			this.itemsListBoxLabel.TabIndex = 2;
			this.itemsListBoxLabel.Text = "Store Items";
			// 
			// addToCart
			// 
			this.addToCart.Location = new System.Drawing.Point(346, 216);
			this.addToCart.Name = "addToCart";
			this.addToCart.Size = new System.Drawing.Size(132, 45);
			this.addToCart.TabIndex = 3;
			this.addToCart.Text = "Add To Cart >";
			this.addToCart.UseVisualStyleBackColor = true;
			this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
			// 
			// shoppingCartListBoxLabel
			// 
			this.shoppingCartListBoxLabel.AutoSize = true;
			this.shoppingCartListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shoppingCartListBoxLabel.Location = new System.Drawing.Point(489, 83);
			this.shoppingCartListBoxLabel.Name = "shoppingCartListBoxLabel";
			this.shoppingCartListBoxLabel.Size = new System.Drawing.Size(124, 20);
			this.shoppingCartListBoxLabel.TabIndex = 5;
			this.shoppingCartListBoxLabel.Text = "Shopping Cart";
			// 
			// shoppingCartListBox
			// 
			this.shoppingCartListBox.FormattingEnabled = true;
			this.shoppingCartListBox.ItemHeight = 20;
			this.shoppingCartListBox.Location = new System.Drawing.Point(493, 106);
			this.shoppingCartListBox.Name = "shoppingCartListBox";
			this.shoppingCartListBox.Size = new System.Drawing.Size(312, 264);
			this.shoppingCartListBox.TabIndex = 4;
			// 
			// makePurchase
			// 
			this.makePurchase.Location = new System.Drawing.Point(677, 376);
			this.makePurchase.Name = "makePurchase";
			this.makePurchase.Size = new System.Drawing.Size(128, 45);
			this.makePurchase.TabIndex = 6;
			this.makePurchase.Text = "Purchase";
			this.makePurchase.UseVisualStyleBackColor = true;
			this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
			// 
			// ConsignmentShop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 581);
			this.Controls.Add(this.makePurchase);
			this.Controls.Add(this.shoppingCartListBoxLabel);
			this.Controls.Add(this.shoppingCartListBox);
			this.Controls.Add(this.addToCart);
			this.Controls.Add(this.itemsListBoxLabel);
			this.Controls.Add(this.itemsListBox);
			this.Controls.Add(this.headerText);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ConsignmentShop";
			this.Text = "Consignment Shop Demo";
			this.Load += new System.EventHandler(this.ConsignmentShop_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerText;
		private System.Windows.Forms.ListBox itemsListBox;
		private System.Windows.Forms.Label itemsListBoxLabel;
		private System.Windows.Forms.Button addToCart;
		private System.Windows.Forms.Label shoppingCartListBoxLabel;
		private System.Windows.Forms.ListBox shoppingCartListBox;
		private System.Windows.Forms.Button makePurchase;
	}
}

