using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public class ProductUtilities
{
    public bool IsProductValid(sportProductsApp.Data.Product product)
    {
        product.ProductCost = Math.Round(product.ProductCost, 2);

        bool IsValid = true;

        StringBuilder errors = new StringBuilder();

        if (string.IsNullOrWhiteSpace(product.ProductName))
            errors.AppendLine("Укажите наименование продукта");

        if (product.Categories == null)
            errors.AppendLine("Выберите категорию");

        if (product.Manufacturers == null)
            errors.AppendLine("Выберите производителя");

        if (product.Units == null)
            errors.AppendLine("Выберите единицу измерения");

        if (product.Suppliers == null)
            errors.AppendLine("Выберите поставщика");

        if (string.IsNullOrWhiteSpace(product.ProductDescription))
            errors.AppendLine("Укажите описание");

        if (product.ProductCost <= 0)
            errors.AppendLine("Неверное значение стоимости товара");

        if (product.ProductPhoto == null)
            errors.AppendLine("Выберите изображение");

        if (errors.Length > 0)
        {
            MessageBox.Show(errors.ToString());
            return false;
        }

        return IsValid;
    }
}