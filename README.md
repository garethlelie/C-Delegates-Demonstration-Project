# C# Delegates Demonstration Project

This project is a **C# console application** that demonstrates the use of **delegates** in .NET for performing mathematical operations and showcasing delegate chaining.

---

## 📌 Features
- Implementation of **delegates** for method references.
- Delegate methods for:
  - Sum of two integers  
  - Product of two integers  
  - Subtraction of two integers  
  - A test method for delegate invocation
- Demonstrates **delegate chaining** by dynamically adding/removing methods.  
- Uses **return-type delegates** to handle methods that return integer values.

---

## 🛠️ Technologies Used
- **C# (.NET Framework / .NET Core)**  
- **Visual Studio / .NET CLI**  

---

## 🚀 How It Works
1. A `CalculateDelegate` is defined to handle methods with two integer parameters.  
2. Methods (`CalcSum`, `CalcProd`, `CalcSub`, `test`) are chained to the delegate.  
3. The delegate executes multiple methods with a single call.  
4. An `IntDelegate` is used for methods that return integer values (`WhatWhat`).  

Example output:
Sub is :30
Sub is :881
Tests 1...2.....3
Int value :0

---

## 📖 Learning Outcomes
- Understand how **delegates** work in C#.  
- Learn how to **chain multiple methods** into a single delegate call.  
- Apply delegates to both `void` and `return-type` methods.  

---

