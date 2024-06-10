using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
	public enum ECouleurs
	{
		[Description("Rouge")]
		ROUGE,
		[Description("Bleu")]
		BLEU,
		[Description("Vert")]
		VERT,
		[Description("Jaune")]
		JAUNE
	}


	public static class EnumExtensions
	{
		public static string GetDescription(this Enum value)
		{
			FieldInfo field = value.GetType().GetField(value.ToString());

			DescriptionAttribute attribute = (DescriptionAttribute)field.GetCustomAttribute(typeof(DescriptionAttribute));

			return attribute == null ? value.ToString() : attribute.Description;
		}
	}

}
