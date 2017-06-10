/*
 * Created by SharpDevelop.
 * User: Татьяна
 * Date: 10.06.2017
 * Time: 21:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Score
{
	/// <summary>
	/// Description of Product.
	/// </summary>
	public abstract class Product
	{
		public string name { get; set; }
		public double price { get; set; }
		public string vendorCode { get; set; }
		
		
		public Product(string name, double price, string vendorCode)
		{
			this.name = name;
			this.price = price;
			this.vendorCode = vendorCode;	
		}
		
		public abstract double CalculatePrice();
		
		public override string ToString()
		{
			return name;
		}
	}
	
	class WeightyProduct : Product
	{
		public double weight { get; set; }
		public WeightyProduct(string name, double price, string vendorCode, double weight) : base (name, price, vendorCode)
		{
			this.weight = weight;
		}
		public override double CalculatePrice()
		{
			return price * weight;
		}

	}
	class PieceProduct : Product
	{
		public int quantity { get; set; }
		public PieceProduct(string name, double price, string vendorCode, int quantity) : base (name, price, vendorCode)
		{
			this.quantity = quantity;
		}
		public override double CalculatePrice()
		{
			return price * quantity;
		}
	}
}
