﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utility
{
    public static class General
    {
        public static bool ValidateEmail(string? email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (email != null)
            {
                return Regex.Match(email, pattern).Success;
            }
            return false;
        }
        public static byte ValidateByte(object? posibleNumero)
        {
            byte numero = 0;
            if (posibleNumero != null)
            {
                string? auxiliar = Convert.ToString(posibleNumero);
                if (byte.TryParse(auxiliar, out numero))
                {
                    return numero;
                }
            }
            return numero;
        }
        public static short ValidateShort(object? posibleNumero)
        {
            short numero = 0;
            if (posibleNumero != null)
            {
                string? auxiliar = Convert.ToString(posibleNumero);
                if (short.TryParse(auxiliar, out numero))
                {
                    return numero;
                }
            }
            return numero;
        }
        public static int ValidateInt(object? posibleNumero)
        {
            int numero = 0;
            if (posibleNumero != null)
            {
                string? auxiliar = Convert.ToString(posibleNumero);
                if (int.TryParse(auxiliar, out numero))
                {
                    return numero;
                }
            }
            return numero;
        }
        public static Int64 ValidateInt64(object? posibleNumero)
        {
            Int64 numero = 0;
            if (posibleNumero != null)
            {
                string? auxiliar = Convert.ToString(posibleNumero);
                if (Int64.TryParse(auxiliar, out numero))
                {
                    return numero;
                }
            }
            return numero;
        }
        public static decimal ValidateDecimal(object? posibleNumero)
        {
            decimal numero = 0;
            if (posibleNumero != null)
            {
                string? auxiliar = Convert.ToString(posibleNumero);
                if (decimal.TryParse(auxiliar, out numero))
                {
                    return numero;
                }
            }
            return numero;
        }
        public static float ValidateFloat(object? posibleNumero)
        {
            float numero = 0;
            if (posibleNumero != null)
            {
                string? auxiliar = Convert.ToString(posibleNumero);
                if (float.TryParse(auxiliar, out numero))
                {
                    return numero;
                }
            }
            return numero;
        }

        public static bool EnviarCorreo(string from, string to, string subject, string body)
        {
            if (string.IsNullOrEmpty(from) || string.IsNullOrWhiteSpace(from) || string.IsNullOrEmpty(to) || string.IsNullOrWhiteSpace(to))
            {
                return false;
            }

            int smtpPort = 587;
            string smtpServer = "smtp-relay.brevo.com";
            string smtpUsername = "mendozajader18@gmail.com";
            string smtpPassword = "";

            try
            {
                MailMessage mail = new(from, to, subject, body);
                SmtpClient smtpClient = new(smtpServer, smtpPort)
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(smtpUsername, smtpPassword),
                    EnableSsl = true
                };
                smtpClient.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}