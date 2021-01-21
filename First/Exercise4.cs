using System;

static class Exercise4
{
    public static void Main()
    {
        var rob = new Robot();
        Robot.Steps actions = null;

        foreach (var ch in Console.ReadLine())
        {
            actions += ch switch
            {
                'R' => rob.Right,
                'L' => rob.Left,
                'F' => rob.Forward,
                'B' => rob.Backward,
            };
        }

        Console.WriteLine(rob.Position());
        actions?.Invoke();
        Console.WriteLine(rob.Position());
    }
}

class Robot
{
    public delegate void Steps();

    int x, y;
    public void Right() => x++;
    public void Left() => x--;
    public void Forward() => y++;
    public void Backward() => y--;
    public string Position() => $"The Robot position: x={x}, y={y}";
}