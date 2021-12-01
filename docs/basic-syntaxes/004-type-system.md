# 数据类型（一）：简介

本节给大家介绍一下 C# 的数据类型，以及变量声明的方式和用法。

## Part 1 让我们先来学习一下基本的用法

**数据类型**（Data Type）是为了规范化管理所有世间万物编程写入代码的时候，进行处理的一种体系。如果没有数据类型这个概念，可能就会像是 Python 那样，编译期间无法察觉任何数据的问题；而在运行的时候才会知道，“Shoot，数据计算的时候出错了”。

数据类型，是把世间万物以编程的视角定义出来的一种“属相”。比如说买菜的单价，是小数类型的（因为可以精确到毛和分）；再比如说排队人数，是整数类型的（严格来说是正整数类型的）。我们通过这样的机制，来表述一个事物的确切数量或者数据的具体大小。

用来临时传达和表示数据大小的手段，就是**变量**（Variable）。比如下面的这段代码，就是通过定义变量，表示一个指定的数据，然后显示在屏幕上的过程：

```csharp
using System;

internal class Program
{
    private static void Main()
    {
        string dogName = "Shiny";
        int age = 5;
        double price = 299.98D;
        
        Console.WriteLine("The dog's name is {0}, {1} years old.", dogName, age);
        Console.WriteLine("When I bought her home, the price is {0}.", price);
    }
}
```

首先，我们来说明一下，每一个数据都是表达什么。首先，我们前面说过，程序的整体执行顺序是从第 7 行开始，到第 12 行结束，那么我们一行一行来看：

第 7 行写的是 `string dogName = "Shiny";`，这句话的意思是，定义了一个叫做 `dogName` 的变量。`dogName` 是我们随手写的名称。显然它并不是 C# 语法规定的成分，因此它是一个标识符。

既然是标识符，那么必然需要满足标识符的书写规范和规则：数字、字母、下划线和 `@` 的组合，首字符不能是数字；后面的字母里不能有 `@`，等等。显然，`dogName` 是符合取名的要求的，因此是一个正确的标识符。从英语本身的角度来说，`dogName` 的实际意思就是“狗狗的名字”。是的，后面我们直接写上了 `"Shiny"`，这个以双引号引起来的东西，我们称为**字符串字面量**（String Literal）。我们通过等号 `=` 来将右侧的这个字面量**赋值给**（Assign）左边的变量，这个行为就叫做**赋值**（Assignment），从人类可以理解的逻辑来看，你可以把 `dogName` 当成一个箱子，这个 `"Shiny"` 就是箱子里装的东西。赋值语句（`string dogName = "Shiny";`）的过程就是把这个东西装进箱子。

我们稍微注意一下，`dogName` 前面有一个 `string`。这就是 `dogName` 的数据类型：string 的意思是“串”，比如英语里的 a string of（一串……）。在这里，`string` 被认为是一个关键字。它的作用就是用来声明一个变量是“串”类型的。所谓的数据类型“串”，就是用来表示“原封不动的数据序列”。它们直接用双引号写出来，然后通过赋值的形式给到变量上去。

同样地，我们可以得到第 8 行和第 9 行类似的理解方式：定义一个 `int` 和 `double` 类型的变量为 `age` 和 `price`，然后分别赋值 `5` 和 `299.98D`。首先，`299.98D` 的字母 `D` 是可以不写的，即 `299.98`，那么就是一个很普通的小数；而 `5` 则是一个很普通的整数。然后，分别通过赋值语句进行赋值。

最后我们来看一下第 11、12 行。第 11 行是我们前文介绍过的 `Console.WriteLine` 方法。这个过程用来输出显示一行文字到屏幕上。不过这里有所变化，因为在使用和显示内容的时候，后面还使用逗号分隔了 `dogName` 和 `age`。细心一点可以看到，整个输出内容里，有两处大括号和数字编号构成的**占位符**（Placeholder）。占位符最后会被后面的变量的数据以对位的形式替换掉。比如说，`{0}` 对应第一个逗号分隔的变量 `dogName`，而 `{1}` 就对应第二个逗号分隔的变量 `age`。

占位符的作用就是体现在 `Console.WriteLine` 里，用来被逗号分隔的变量作替换的。按照 C# 语法的约定，占位符的编号（0、1、2 这些）可以重复使用，但必须从 0 开始编号。比如说

```csharp
string variable = "years old";
int a = 30;
int b = 40;
Console.WriteLine("I'm {1} {0}, while she is {2} {0}.", variable, a, b);
```

这里的 `{0}` 被 `"years old"` 字符串字面量替换，`{1}` 则被 `30` 替换，`{2}` 被 40 替换，所以输出内容就是

```
I'm 30 years old, while she is 40 years old.
```

大概就是这么一个感觉。

> 顺带一提，第 10 行没有东西，我们把这种“单纯是为了排版好看，为了分清执行逻辑部分”的空白行称为**空行**（Null Line）。空行仅用来分隔和划分执行逻辑的部分，比如说这个空行的前面是定义变量，后面则是输出内容，它们的作用是不一样的，使用空行可以让代码更美观。

最后，前面示例最终的显示结果是这样的：

```
The dog's name is Shiny, 5 years old.
When I bought her home, the price is 299.98.
```

再顺带一提，`int` 和 `double` 在 C# 里分别表示整数和小数。整数和小数在 C# 里分得非常细致，所以并不是只有 `int` 就表示整数类型，也并不是只能用 `double` 来表示小数。下面我们就来看一下，C# 预定义的数据类型。

## Part 2 C# 自带的数据类型

在 C# 的世界里，规定了许多基本的数据类型。我们都来看一看。

| 类型名    | 类型名称           | 取值范围（用闭区间表示）  | 全称             | 独特的字面量格式                    |
| --------- | ------------------ | ------------------------- | ---------------- | ----------------------------------- |
| `sbyte`   | 带符号字节型       | [-128, 127]               | `System.SByte`   |                                     |
| `byte`    | 字节型             | [0, 255]                  | `System.Byte`    |                                     |
| `ushort`  | 无符号短整数       | [0, 65535]                | `System.UInt16`  |                                     |
| `short`   | 短整数             | [-32768, 32767]           | `System.Int16`   |                                     |
| `uint`    | 无符号整数         | [0, 4294967295]           | `System.UInt32`  | `0U` 或 `0u`                        |
| `int`     | 整数               | [-2147483648, 2147483647] | `System.Int32`   |                                     |
| `ulong`   | 无符号长整数       | [0, $2^{64} - 1$]         | `System.UInt64`  | `0UL` 或 `0ul`                      |
| `long`    | 长整数             | [-$2^{63}$, $2^{63} - 1$] | `System.Int64`   | `0L` 或 `0l`                        |
| `float`   | 单精度二进制浮点数 |                           | `System.Single`  | `0F` 或 `0f`                        |
| `double`  | 双精度二进制浮点数 |                           | `System.Double`  | `0D` 或 `0d`<br />`1E+2` 或 `1e+2`  |
| `decimal` | 十进制浮点数       |                           | `System.Decimal` | `0M` 或 `0m`                        |
| `bool`    | 布尔               | { `true`, `false` }       | `System.Boolean` | `true` 或 `false`                   |
| `char`    | 字符               |                           | `System.Char`    | `'c'`<br />`'\u0067'`<br />`'\x43'` |
| `string`  | 字符串             |                           | `System.String`  | `"string"`<br />`@"C:\Users"`       |

整个表格根本不需要背下来。毕竟不是考试。你只需要知道，什么是无符号、什么是二进制小数、什么是十进制小数、什么是布尔就可以了。

**无符号**（Unsigned）和**带符号**（Signed）就是我们俗称的“非负整数”和“正负整数”。无符号整数就是没有负数范围的整数（也就是 0 和正整数）；带符号整数就是这个取值范围既可以在正整数这一边，也可以到负整数这一边，也可以是 0 的情况。由于电脑存储机制有限的缘故，我们无法存储一个特别大的数据进去（而这样的数据确实用得也很少）。C# 将我们使用的数据做了一个区分和范围定界。比如说，如果要用变量表示开会人数的话，显然开会的人数再怎么多，也不可能超过几万吧；而且，人数这个量不能是负值。所以按照 C# 的约定，我们应当选取 `ushort` 作为最合适的数据类型来表示：`ushort popularity = 3000;`。

你可能会问我，我选 `int` 不是也可以？反正 `int` 范围那么大，3000 肯定是在其中的。是的，你没有说错。也正是因为这个原因，前文说的是“我们应当选取”，而不是“我们必须选取”。只要我们预估的数据的可能取值在一个指定范围内的话，就随便你怎么选都 OK。所以，`int popularity = 3000;` 是没有问题的；但是，如果你写 `byte popularity = 3000;` 必然是错误的。

接着说一下**浮点数**（Floating-point Number）。在计算机的世界里，浮点数其实就是小数的官方说法。因为在计算机的内部，小数是通过科学计数法表达的，因此小数点就变成了漂浮不定的了，因而称为浮点数（小数点漂浮不定的数字）。

小数在计算机里有两种表达模型，一种叫**二进制小数**（Binary Floating-point），一种则是**十进制小数**（Decimal Floating-point）。二进制小数就是将小数用 $a \times 2^b$ 的方式表达出来；而十进制小数就是 $a \times {10}^b$ 了。别看只是 2 和 10 变了，实际上数据的存储精度也会变化。

在学习小数的二进制表达的时候，我们知道，很多小数在十进制下是精确的，但表示成二进制之后，小数就不再精确了；相反，它们在二进制表达下，反而变成了无限循环小数。因为计算机存储机制的限制，这些数据不能精确存储，“无限循环小数”直接被**截断**（Truncate）为“有限小数”，因而数据本身都发生变化了，所以就不精确了。

我们无需了解底层存储浮点数的方式（如果确实需要了解相关内容，请参看 IEEE 754 规范），所以只需要知道浮点数是不精确的就行了。

浮点数一共有三种，它们的范围也有一些区别，最小的是 `float`，能精确大约 6 位有效数字；`double` 则大约能到 12 位有效数字；`decimal` 则精度更高（甚至能达到 28 位左右）。但是，它们范围最小都能表达到 10 的 38 次方，所以完全不用担心运算超出数据范围。由于从使用上来说，三种数据类型只有精度和数据范围的区别，实际上没别的区别，因此这里就不作很细的区分了；如果用到了确实需要讲的区别，我们会在后续内容里说明。

**布尔**（Boolean）类型说白了就是我们平时生活中用来回答“对”和“错”的这两个数值。“对”在 C# 里用关键字 `true` 表示，而“错”就用的是关键字 `false` 表示。比如说：

```csharp
bool condition = true;
bool anotherCondition = false;
```

大概是这么一种感觉。当然，从另外一个角度来说，布尔型数据的数据取值范围**只有这两个数值**；但别看只有这两个取值，但它的用处很多，也很重要，以后在讲解条件、循环结构的时候，会广泛使用布尔型数据。

> 最后，字符和字符串我们将放在后面的内容给大家介绍。因为这个内容说起来很多，因此单独成一节内容。
>
> 然后看到表格，稍微注意一下的是，字节型数据和带符号字节型，以及其它的整数类型是有区别的：字节型数据是默认无符号的，要使用带有负数的范围的字节型数据，需要追加 s 字母（signed 这个单词）；而其它的整数默认就是带符号的（有负数范围的），需要使用无符号的类型，则需要追加 u 字母（unsigned 单词）。

## Part 3 基础类库名

前文提到的这些数据类型，除了使用前面的关键字作为类型名称以外，还可以使用全称。可以从前面的表格里看到，它们的全称都带“System.”。是不是很眼熟？是的，这就是我们之前说 `Console` 的时候，需要引入的命名空间。是的，所有这些类型都是系统自带的，因此全部被包含在 `System` 命名空间下。如果你使用它们，要么直接使用关键字，要么写全称。写全称就需要你先写上 `using System;` 才可以使用它们。

```csharp
// BCL name way to declare a variable.
using System;
Int32 i = 10;

// Keyword way to declare a variable.
int j = 30;
```

它们是等价的两种写法，唯一的区别就是，全称写法需要引入 `System`；而 `int` 这类关键字的话，直接用，不用写引用指令，系统会自动追加 `using System;` 这一条指令。

> 哦对了，这些数据类型的全称，我们称为**基础类库**（Basic Class Library，简称 BCL）名称。

## Part 4 总结

本节内容给大家做了一个基本的数据类型的介绍，还说了变量的声明方式，以及使用的方式（通过占位符和 `Console.WriteLine` 方法配套使用）。

下一节内容，我们会继续探讨数据类型。因为……字面量，还有字符、字符串类型我们都还没说呢。
