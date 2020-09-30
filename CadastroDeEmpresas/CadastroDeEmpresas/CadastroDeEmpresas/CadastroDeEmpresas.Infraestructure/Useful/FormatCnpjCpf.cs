using System;

public static class FormatCnpjCpf
{
    // Methods:

    public static string FormatCnpj(string cnpj)
    {
        return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
    }

    public static string FormatCpf(string cpf)
    {
        return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
    }

    public static string WithoutFormat(string code)
    {
        return code.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
    }
}