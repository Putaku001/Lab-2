using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PresentationLayer.Validation
{
    public static class ClientFormValidation
    {
        public static bool ValidateName(string name, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(name) || name.StartsWith(" "))
            {
                errorMessage = "El nombre no puede estar vacío ni tener espacios al inicio.";
                return false;
            }

            if (Regex.IsMatch(name, @"\d"))
            {
                errorMessage = "El nombre no puede contener números.";
                return false;
            }

            return true;
        }
        public static bool ValidateLastName(string lastName, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(lastName) || lastName.StartsWith(" "))
            {
                errorMessage = "El Apellido no puede estar vacío ni tener espacios al inicio.";
                return false;
            }

            if (Regex.IsMatch(lastName, @"\d"))
            {
                errorMessage = "El Apellido no puede contener números.";
                return false;
            }

            return true;
        }

        public static bool ValidatePhone(string phone, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(phone) || phone.StartsWith(" "))
            {
                errorMessage = "El teléfono no puede estar vacío ni tener espacios al inicio.";
                return false;
            }

            if (!Regex.IsMatch(phone, @"^\d+$"))
            {
                errorMessage = "El teléfono solo puede contener números.";
                return false;
            }

            if (phone.Length < 8 || phone.Length > 15)
            {
                errorMessage = "El teléfono debe tener entre 8 y 15 caracteres.";
                return false;
            }

            return true;
        }

        public static bool ValidateLicense(string license, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(license) || license.StartsWith(" "))
            {
                errorMessage = "La licencia no puede estar vacío ni tener espacios al inicio.";
                return false;
            }

            if (!Regex.IsMatch(license, @"^\d+$"))
            {
                errorMessage = "La Licencia solo puede contener números.";
                return false;
            }

            if (license.Length < 9 || license.Length > 10)
            {
                errorMessage = "La Licencia debe tener entre 9 y 10 caracteres.";
                return false;
            }

            return true;
        }
    }
}