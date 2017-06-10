/*
 * Created by SharpDevelop.
 * User: Татьяна
 * Date: 10.06.2017
 * Time: 21:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;


namespace Score
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Вasket basket;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			basket = new Вasket();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		
		
		void AddProductClick(object sender, EventArgs e)
		{
			basket.AddProduct((Product)products.SelectedItem);
			
			sum.Text =  basket.CalculatePrice().ToString();
			count.Text = basket.CalculateQuantity().ToString();
			
			
		}
		
	}
}
