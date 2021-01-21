using System;

static class Exercise3
{
    delegate double delegateConvertTemperature(double temperature);

    public static void Main() {
        var converter = new TemperatureConverterImp();

        // Следующие два способа совершенно одинаковы, см. sharplab.io:
        var toCelsius = new delegateConvertTemperature(converter.ToCelsius);
        delegateConvertTemperature toFarenheits = converter.ToFarenheits;

        Console.WriteLine($"100⁰C = {toFarenheits(100)}⁰F");
        Console.WriteLine($"100⁰F = {toCelsius(100)}⁰C");
    }
}

class TemperatureConverterImp
{
    public double ToCelsius(double farenheits)
    {
        return (farenheits - 32) * 5 / 9;
    }

    public double ToFarenheits(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }
}