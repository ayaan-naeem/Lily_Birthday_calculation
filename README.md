## Lily's Washing Machine Savings Calculator

A simple console application that determines whether Lily can afford a washing machine with the money she saves and receives as birthday gifts up to her current age.

## Problem Description (Original Story)

Lily is a little girl who receives money on her birthdays instead of toys starting from a certain age. The rules are:

- On **odd birthdays** (1, 3, 5, 7, …) she receives a toy.
- On **even birthdays** (2, 4, 6, 8, …) her brother gives her **$10 more than the previous even birthday**, but she has to give **$1** to her brother as a "thank you" tax.

Typical example:
- Age 2 → $10 – $1 = $9 saved
- Age 4 → $20 – $1 = $19 saved
- Age 6 → $30 – $1 = $29 saved
- etc.

She wants to know if, by her current age, she has saved enough money (from even birthdays + selling all the toys she received on odd birthdays) to buy a washing machine.

## Features

- Reads Lily's current age
- Reads the price of one toy
- Reads the price of the desired washing machine
- Calculates total money saved according to the birthday gift rules
- Determines whether she can buy the washing machine
- Shows the remaining money or the missing amount

## Input

The program asks for three integers:

1. **Age of Lily** (current age in years)
2. **Price of one toy** (in dollars)
3. **Price of the washing machine** (in dollars)

## Output

## One of two possible messages:
Yes! Lily can buy the washing machine and will have X dollars left.
textor
No! Lily cannot buy the washing machine and needs Y dollars more.
text## Current Algorithm (as implemented)

## ```text
money_from_even_birthdays = 0
toys_money = 0

## For each odd year from 1 to (age-1):
    toys_money += toy_price

## For each even year from 2 to (age-1):
    money_from_even_birthdays += 10    (but buggy implementation!)
    money_from_even_birthdays -= 1

## Important note:
The current implementation contains a logical bug — it adds only $9 every even year instead of progressively increasing amounts ($9 + $19 + $29 + …).
Correct expected logic (most common version of this problem):
texteven_years = (age-1) // 2
money = 0

for i in 1 to even_years:
    money += (10 * i) - 1
or more efficiently:
C#int evenYears = (age - 1) / 2;
int money = evenYears * (evenYears + 1) * 5 - evenYears;   // = 10*(1+2+...+n)/2 - n
How to Run
Bash# Compile (if needed)
csc Program.cs

## or just run if using dotnet
dotnet run
Then enter three numbers when prompted.

## Example Run
textEnter the age of Lily: 10
Enter the price of toys: 5
Enter the price of washing machine: 70

No! Lily cannot buy the washing machine and needs 3 dollars more.
