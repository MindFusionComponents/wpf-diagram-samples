//
// Copyright (c) 2025, MindFusion LLC - Bulgaria.
//

using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace MindFusion
{
	internal class FilterBasePropertiesTypeConverter : ExpandableObjectConverter
	{
		public FilterBasePropertiesTypeConverter()
		{
		}

		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		public override PropertyDescriptorCollection GetProperties(
			ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(value);

			List<PropertyDescriptor> descriptors = new List<PropertyDescriptor>();
			foreach (PropertyDescriptor property in properties)
			{
				if (property.ComponentType.Equals(value.GetType()) &&
					!property.Name.Contains("."))
					descriptors.Add(property);
			}

			return new PropertyDescriptorCollection(descriptors.ToArray());
		}
	}

	[TypeConverter(typeof(ObjectWrapperTypeConverter))]
	public class ObjectWrapper
	{
		public ObjectWrapper(object inner)
		{
			this.inner = inner;
		}


		/// <summary>
		/// Gets a reference to the wrapped object.
		/// </summary>
		[Browsable(false)]
		internal object Inner
		{
			get { return inner; }
		}


		private object inner;
	}


	internal class ObjectWrapperTypeConverter : TypeConverter
	{
		/// <summary>
		/// Initializes a new instance of the ObjectWrapperTypeConverter class.
		/// </summary>
		public ObjectWrapperTypeConverter()
		{
		}

		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		public override PropertyDescriptorCollection GetProperties(
			ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			// Create a property for each item in the collection
			ObjectWrapper wrapper = value as ObjectWrapper;

			PropertyDescriptorCollection properties =
				TypeDescriptor.GetProperties(wrapper.Inner);

			List<PropertyDescriptor> descriptors = new List<PropertyDescriptor>();

			foreach (PropertyDescriptor property in properties)
			{
				if (property.IsBrowsable)
				{
					if (property.ComponentType.FullName.Contains("MindFusion.Diagramming") &&
						!property.Name.Contains(".") && !property.IsReadOnly)
					{
						descriptors.Add(new ObjectWrapperPropertyDescriptor(property,
							typeof(ObjectWrapper), property.Name, property.PropertyType));
					}
				}
			}

			return new PropertyDescriptorCollection(descriptors.ToArray());
		}

		protected class ObjectWrapperPropertyDescriptor : SimplePropertyDescriptor
		{
			/// <summary>
			/// Initializes a new instance of the ObjectWrapperPropertyDescriptor class.
			/// </summary>
			public ObjectWrapperPropertyDescriptor(PropertyDescriptor innerProperty,
				Type componentType, string name, Type propertyType)
				: base(componentType, name, propertyType)
			{
				this.innerProperty = innerProperty;
			}

			public override object GetValue(object component)
			{
				ObjectWrapper wrapper = component as ObjectWrapper;
				return innerProperty.GetValue(wrapper.Inner);
			}

			public override void SetValue(object component, object value)
			{
				ObjectWrapper wrapper = component as ObjectWrapper;
				innerProperty.SetValue(wrapper.Inner, value);

				OnValueChanged(component, EventArgs.Empty);
			}

			public override bool ShouldSerializeValue(object component)
			{
				ObjectWrapper wrapper = component as ObjectWrapper;
				return innerProperty.ShouldSerializeValue(wrapper.Inner);
			}

			public override void ResetValue(object component)
			{
				ObjectWrapper wrapper = component as ObjectWrapper;
				innerProperty.ResetValue(wrapper.Inner);
			}


			public override bool DesignTimeOnly
			{
				get { return innerProperty.DesignTimeOnly; }
			}

			public override string Category
			{
				get { return innerProperty.Category; }
			}

			public override string Description
			{
				get { return innerProperty.Description; }
			}

			public override AttributeCollection Attributes
			{
				get { return innerProperty.Attributes; }
			}

			public override string DisplayName
			{
				get { return innerProperty.DisplayName; }
			}

			public override bool IsBrowsable
			{
				get { return innerProperty.IsBrowsable; }
			}

			public override bool IsReadOnly
			{
				get { return innerProperty.IsReadOnly; }
			}

			public override string Name
			{
				get { return innerProperty.Name; }
			}

			public override Type PropertyType
			{
				get { return innerProperty.PropertyType; }
			}


			/// <summary>
			/// A property descriptor of the corresponding property on the wrapped object.
			/// </summary>
			private PropertyDescriptor innerProperty;
		}
	}
}
