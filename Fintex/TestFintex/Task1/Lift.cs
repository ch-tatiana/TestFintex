using System;

class Elevator
{
    private int currentFloor;
    private int minFloor;
    private int maxFloor;

    public Elevator(int minFloor, int maxFloor)
    {
        this.minFloor = minFloor;
        this.maxFloor = maxFloor;
        this.currentFloor = 1;
    }

    public int getCurrentFloor()
    {
        return currentFloor;
    }

    public void moveDown(){
        if (currentFloor > minFloor)
        {
            currentFloor--;
            Console.WriteLine("Текущий этаж: " + currentFloor);
        } 
        else {
            Console.WriteLine("Лифт на минимальном этаже");
        }
    }

    public void moveUp(){
        if (currentFloor < maxFloor)
        {
            currentFloor++;
            Console.WriteLine("Текущий этаж: " + currentFloor);
        } 
        else {
            Console.WriteLine("Лифт на максимальном этаже");
        }
    }

    public void move(int floor)
    {
        if (floor < minFloor || floor > maxFloor)
        {
            Console.WriteLine("Ошибка. Задан неверный этаж");
            return;
        }
        while(currentFloor != floor)
        {
            if (currentFloor < floor)
            {
                moveUp();
            }
            else 
            {
                moveDown();
            }
        }
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Elevator elevator = new Elevator(-3, 26);
        while (true)
        {
            Console.WriteLine("Введите номер этажа: ");
            int floor = Convert.ToInt32(Console.ReadLine());
            elevator.move(floor);
        }
    }
}