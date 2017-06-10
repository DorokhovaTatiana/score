/*
 * Created by SharpDevelop.
 * User: Татьяна
 * Date: 10.06.2017
 * Time: 22:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Score
{
	/// <summary>
	/// Description of Вasket.
	/// </summary>
	public class Вasket
	{
		List<Product> currentBasket { get; set; }
		public Вasket()
		{
			currentBasket = new List<Product>();
		}
		
		public void AddProduct(Product product)
		{
			currentBasket.Add(product);
		}
		public double CalculatePrice()
		{
			return currentBasket.Sum(x => x.CalculatePrice());
		}
		public int CalculateQuantity()
		{
			return currentBasket.Count;
		}
	}
}
