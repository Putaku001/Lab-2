using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PresentationLayer.Validation
{
    public static class CarsFormValidation
    {
        public static bool ValidateBrand(string brand, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(brand))
            {
                errorMessage = "La marca no puede estar vacía.";
                return false;
            }

            if (brand.StartsWith(" "))
            {
                errorMessage = "La marca no puede comenzar con un espacio.";
                return false;
            }

            if (brand.Length < 3)
            {
                errorMessage = "La marca debe tener al menos 3 caracteres.";
                return false;
            }

            if (Regex.IsMatch(brand, @"\d"))
            {
                errorMessage = "La marca no puede contener números.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public static bool ValidateModel(string model, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(model))
            {
                errorMessage = "El modelo no puede estar vacío.";
                return false;
            }

            if (model.StartsWith(" "))
            {
                errorMessage = "El modelo no puede comenzar con un espacio.";
                return false;
            }

            if (model.Length < 3)
            {
                errorMessage = "El modelo debe tener al menos 3 caracteres.";
                return false;
            }

            errorMessage = string.Empty;
            return true;

        }

        public static bool ValidateYear(string yearText, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(yearText))
            {
                errorMessage = "El año no puede estar vacío.";
                return false;
            }

            if (!int.TryParse(yearText, out int year) || year < 1886 || year > DateTime.Now.Year)
            {
                errorMessage = "El año debe ser un número válido entre 1886 y el año actual.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}

