using System;
using System.ComponentModel.DataAnnotations;

namespace DevDash.Web.Models
{
	public class Expense
	{
		public int Id { get; set; }
		public decimal Value { get; set; }

		[Required]
		public string? Description { get; set; }
	}
}

