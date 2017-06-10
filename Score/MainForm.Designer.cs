/*
 * Created by SharpDevelop.
 * User: Татьяна
 * Date: 10.06.2017
 * Time: 21:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Score
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label productsList;
		private System.Windows.Forms.ListBox products;
		private System.Windows.Forms.GroupBox basketProduct;
		private System.Windows.Forms.Label productQuantity;
		private System.Windows.Forms.Label sumPrice;
		private System.Windows.Forms.Button addProduct;
		private System.Windows.Forms.Label count;
		private System.Windows.Forms.Label sum;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.products = new System.Windows.Forms.ListBox();
			this.productsList = new System.Windows.Forms.Label();
			this.basketProduct = new System.Windows.Forms.GroupBox();
			this.productQuantity = new System.Windows.Forms.Label();
			this.sumPrice = new System.Windows.Forms.Label();
			this.addProduct = new System.Windows.Forms.Button();
			this.sum = new System.Windows.Forms.Label();
			this.count = new System.Windows.Forms.Label();
			this.basketProduct.SuspendLayout();
			this.SuspendLayout();
			// 
			// products
			// 
			this.products.FormattingEnabled = true;
			this.products.Location = new System.Drawing.Point(39, 37);
			this.products.Name = "products";
			this.products.Size = new System.Drawing.Size(381, 173);
			this.products.TabIndex = 0;
			this.products.Items.Add(new PieceProduct("Мышь", 780, "М-02", 5));
			this.products.Items.Add(new PieceProduct("Клавиатура", 1450, "Кд-02", 10));
			this.products.Items.Add(new WeightyProduct("Картофель", 14.5, "К-2017", 3));
			
			// 
			// productsList
			// 
			this.productsList.Location = new System.Drawing.Point(183, 9);
			this.productsList.Name = "productsList";
			this.productsList.Size = new System.Drawing.Size(100, 23);
			this.productsList.TabIndex = 1;
			this.productsList.Text = "Список товаров";
			// 
			// basketProduct
			// 
			this.basketProduct.Controls.Add(this.count);
			this.basketProduct.Controls.Add(this.sum);
			this.basketProduct.Controls.Add(this.productQuantity);
			this.basketProduct.Controls.Add(this.sumPrice);
			this.basketProduct.Location = new System.Drawing.Point(39, 248);
			this.basketProduct.Name = "basketProduct";
			this.basketProduct.Size = new System.Drawing.Size(200, 100);
			this.basketProduct.TabIndex = 2;
			this.basketProduct.TabStop = false;
			this.basketProduct.Text = "Корзина";
			// 
			// productQuantity
			// 
			this.productQuantity.Location = new System.Drawing.Point(7, 47);
			this.productQuantity.Name = "productQuantity";
			this.productQuantity.Size = new System.Drawing.Size(100, 23);
			this.productQuantity.TabIndex = 1;
			this.productQuantity.Text = "Товар";
			// 
			// sumPrice
			// 
			this.sumPrice.Location = new System.Drawing.Point(6, 24);
			this.sumPrice.Name = "sumPrice";
			this.sumPrice.Size = new System.Drawing.Size(49, 23);
			this.sumPrice.TabIndex = 0;
			this.sumPrice.Text = "Сумма";
			// 
			// addProduct
			// 
			this.addProduct.Location = new System.Drawing.Point(291, 225);
			this.addProduct.Name = "addProduct";
			this.addProduct.Size = new System.Drawing.Size(129, 27);
			this.addProduct.TabIndex = 3;
			this.addProduct.Text = "Добавить в корзину";
			this.addProduct.UseVisualStyleBackColor = true;
			this.addProduct.Click += new System.EventHandler(this.AddProductClick);
			// 
			// sum
			// 
			this.sum.Location = new System.Drawing.Point(53, 24);
			this.sum.Name = "sum";
			this.sum.Size = new System.Drawing.Size(100, 23);
			this.sum.TabIndex = 2;
			// 
			// count
			// 
			this.count.Location = new System.Drawing.Point(53, 47);
			this.count.Name = "count";
			this.count.Size = new System.Drawing.Size(100, 23);
			this.count.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 371);
			this.Controls.Add(this.addProduct);
			this.Controls.Add(this.basketProduct);
			this.Controls.Add(this.productsList);
			this.Controls.Add(this.products);
			this.Name = "MainForm";
			this.Text = "Score";
			this.basketProduct.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
