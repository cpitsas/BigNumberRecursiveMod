# 🧮 BigNumberRecursiveMod

[![NuGet Version](https://img.shields.io/nuget/v/BigNumberRecursiveMod.svg?style=for-the-badge)](https://www.nuget.org/packages/BigNumberRecursiveMod/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/BigNumberRecursiveMod.svg?style=for-the-badge)](https://www.nuget.org/packages/BigNumberRecursiveMod/)
[![License](https://img.shields.io/github/license/cpitsas/BigNumberRecursiveMod.svg?style=for-the-badge)](LICENSE)

> A lightweight, zero-dependency C# library for recursively calculating modular arithmetic on **very large integer sequences represented as strings** — without converting them into BigIntegers.

---

## 📘 Overview

**BigNumberRecursiveMod** provides an efficient and recursive approach to compute the modulo (`%`) of extremely large numbers represented as string sequences — perfect for cases where numbers exceed `Int64` or `BigInteger` parsing limits.

It operates recursively by:
- Splitting the number sequence into manageable chunks
- Recursively processing higher-order digits
- Efficiently combining results using modular arithmetic

This approach mimics manual long division but is implemented with recursion for simplicity and clarity.

---

## 🧩 Why Use Recursive Modulo?

When dealing with **very large integers**, standard integer types (`int`, `long`, `BigInteger`) can be inefficient or impossible to use — especially if numbers are stored or streamed as strings (e.g., from JSON, logs, or APIs).

This library solves that by:
- Working **entirely on string-based numbers**
- Avoiding **overflow**
- Remaining **lightweight**, **pure C#**, and **dependency-free**
- Providing **clear and testable logic** via recursion

---

## ⚙️ Installation

```bash
dotnet add package BigNumberRecursiveMod
```

---

## 🚀 Quick Start

### Example 1: Using a String Divider

```csharp
using BigNumberRecursiveMod;

string numberSequence = "777635";
string divider = "32";

int mod = RecursiveMod.CalculateMod(numberSequence, divider);

Console.WriteLine(mod); // Output: 3
```

### Example 2: Using an Integer Divider

```csharp
using BigNumberRecursiveMod;

string numberSequence = "491984984";
int divider = 978;

int mod = RecursiveMod.CalculateMod(numberSequence, divider);

Console.WriteLine(mod); // Output: 128
```

### Example 3: Extremely Large Numbers

```csharp
using BigNumberRecursiveMod;

string numberSequence = "41646849849849161654198498498498498498498498465416515151564651189198484000084984987496874984984984894984984984984981";
string divider = "97";

int mod = RecursiveMod.CalculateMod(numberSequence, divider);

Console.WriteLine(mod); // Always less than 97
```

---

## 🧠 How It Works

```csharp
private static int CalculateRecursive(string numberSequence, int divider, int n)
{
    if (numberSequence.Length <= n)
        return int.Parse(numberSequence) % divider;

    string head = numberSequence.Substring(0, numberSequence.Length - n);
    string tail = numberSequence.Substring(numberSequence.Length - n, n);

    int headMod = CalculateRecursive(head, divider, n);
    int combinedMod = (headMod * (int)Math.Pow(10, n) + int.Parse(tail)) % divider;

    return combinedMod;
}
```

### 🔍 Process
1. Split the number into smaller chunks.
2. Recursively compute modulo on higher-order digits.
3. Combine results using modular arithmetic.

---

## ✅ Unit Tests

```csharp
[Fact]
public void LargeNumberTest()
{
    string numberSequence = "999999";
    string divider = "68";

    int mod = RecursiveMod.CalculateMod(numberSequence, divider);

    Assert.Equal(59, mod);
}
```

---

## 🧰 API Reference

### `RecursiveMod.CalculateMod(string numberSequence, string divider)`
Calculates the modulo of a string-based number sequence with a string divider.

### `RecursiveMod.CalculateMod(string numberSequence, int divider)`
Calculates the modulo of a string-based number sequence with an integer divider.

---

## ⚠️ Exception Handling

| Exception Type | Description |
|----------------|-------------|
| `ArgumentException` | Thrown if `divider` is not a valid integer. |
| `ArgumentException` | Thrown if `numberSequence` contains non-digit characters. |

---

## 🧱 Project Structure

```
BigNumberRecursiveMod/
├── BigNumberRecursiveMod/
│   ├── RecursiveMod.cs
│   └── BigNumberRecursiveMod.csproj
├── TestRecursiveMod/
│   ├── RecursiveModTest.cs
│   └── TestRecursiveMod.csproj
├── README.md
└── LICENSE
```

---

## 📝 License

This project is licensed under the [MIT License](LICENSE).

---

## ❤️ Contributing

Pull requests are welcome!  
If you find a bug or have a suggestion:
1. Fork the repo  
2. Create a new branch (`feature/amazing-feature`)  
3. Commit your changes  
4. Open a PR  

---

## 👨‍💻 Author

**Your Name**  
GitHub: [@yourusername](https://github.com/yourusername)  
NuGet: [BigNumberRecursiveMod](https://www.nuget.org/packages/BigNumberRecursiveMod/)
