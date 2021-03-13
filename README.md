# StudyCSharp21
박효진 C# 학습 리포지토리

## 1. Basic C#   
기본문법 학습 

### 1-1) C#이란?  
```
◇ 마이크로 소프트에서 개발된 객체 지향 프로그래밍 언어    
◇.NetFramework를 이용하여 프로그래밍하는 대표적인 언어   
◇ 윈도우 프로그래밍, 웹 프로그래밍, 게임 및 모바일 프로그래밍 등
   모든 영역에서 사용되는 범용 프로그래밍 언어   
```   
---

### 1-2) C# 데이터 타입   
+ bool | True or False   
+ byte, sbyte | 8비트   
+ short, ushort | 16비트   
+ int, unit | 32비트   
+ long, ulong | 64비트   
+ Float | 32비트 부동소수점 숫자
+ double | 64비트 부동소수점 숫자   
+ deciaml | 128비트   
+ char | 16비트 유니코드 문자   
+ string | 유니코드 문자열    
+ System.DateTime | 날짜와 시간, 별도의 C#키워드 없음   
+ Object | 모든 타입의 기본 클래스로 모든 유형을 포함 할 수 있음   
+ int.MaxValue, int.MinValue | 최댓값, 최솟값   
+ Null | 값이 아닌 값 "아무리 생각해도 난 NULL을~♬"   
---

### 1-3) C#데이터 형식 : 데이터 
+ 기본 데이터 형식
+ 변수, 상수, 열거형
+ 복합 데이터 형식
   + 구조체
   + 클래스
   + 배열
+ 값 형식
+ 참조 형식   

#### (1) 기본 데이터 형식
+ 값 형식
   + 숫자 형식
   + 논리 형식   
+ 참조 형식
   + 문자열 형식
   + 오브젝트 형식

#### (2) 값 형식과 참조 형식   
+ 값 형식 (Stack)
   + 변수에서 값을 담는 형식
+ 참조 형식 (Heap)
   + 값이 있는 곳의 위치를 담는 형식   
```
스택   
   - 책 더미와 같은 구조로 생긴 메모리
   - 값 형식의 변수를 저장
   - 저장된 데이터 자체를 제거
힙
   - 코드블록이 끝나도 데이터 유지   
※ 참조 형식의 변수   
   힙 : 데이터 저장
   스택 : 힙의 메모리 주소    
```   
스택
![참조1](/Media/Stack2.png "스택")    
스택과 힙   
<img src="https://github.com/hyojin-park24/StudyCSharp21/blob/main/Media/stack%EA%B3%BC%20Heap2.png"/>    

#### (3) 변수 및 상수  

**(3-1) 변수**
```   
변수는 변하는 수이다.    
조금 더 쉽게 접근하자면 작성자는 이렇게 말하고 싶다.    
"판도라의 상자"   
```   
+ 변수 : 값을 담아두는 형태   
+ 하나의 데이터 값을 가질 수 있으며, 값이 고정적이지 않고 변할 수 있음   
+ 변수의 자료형   
  + 정수형
    + sybte, byte, short, ushort, int, unit, long, ulong
  + 실수형
    + float, double, decimal
  + 문자형
    + char, string
  + 불린형
    + bool 
+ 모든 C# 변수의 이름은 대소문자를 구별(case-sensitive)한다.

#### (3-2) 변수 선언 방법   
**<32비트 정수형과 64비트 정수형>**   
```
int n; //32비트 정수형
long sum; // 64비트 정수형   
```   

**<Hello, World! 문자형>**   
```ruby
using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! from .NETCore");
        }
    }
}
```   

#### (3-3) 상수  
```ruby
상수란?

코드를 작성하다가 나도 모르게 값을 변경하지 말아야 할 변수를 건드려서 버그가 발생할 수 있다.
이 문제를 쉽게 해결해주는 const라는 상수이다.
const를 사용하게 되면 한번 초기화 된 값은 절대 변하지 않는것이 변수와의 차이점 이다.

using System;

namespace ConstTestApp
{
    class Program
    {
        enum Season // 열거형 ( 하나의 타입으로 표현 )
        {
            Spring,
            Summer,
            Fall,
            Winter
        }
        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double PI = 3.141592;
            Console.WriteLine($"원주율의 값는 {PI}");
            // PI = 6.345;

            Season mySeason = Season.Summer;
            Console.WriteLine($"지금 계절은 핫 써머 아 핫핫 써머 일까요? {mySeason} 였습니다!");

            int a = 0; //null 허용 안됌
            Console.WriteLine($"a는 {a}");
            int? b = null;
            Console.WriteLine($"b는 {b}");

        }
    }
}   
```   

#### (3-4) ENUM (열거형)   
**열거형이란?**   
enum은 열거형 상수(constant)를 표현하기 위해 태어났다.   
enum을 통해 상수 숫자들을 의미있는 단어로 표현이 가능하고, 
프로그램을 쉽게 읽을 수 있게 만들어 준다.

+ 각 요소는 별도의 지정 없이 첫번째 요소가 0부터 시작함
+ 개발자가 임의로 의미있는 번호 지정 가능
+ 클래스 안 OR 네임스페이스 안에서만 선언 가능
+ 메서드 OR 속성 안에서 선언    

#### (4) 오버플로우 (OverFlow)와 언더플로우 (Underflow)   
```ruby
- 데이터가 흘러 넘쳤을 때: 데이터 형식의 최대값을 넘어가는 데이터를 저장 할 때
- 언더플로우: 최저 값 보다 작은 데이터를 저장할 때   

namespace OverflowTestApp
{
    public partial class Form1_Load : Form
    {
        public Form1_Load()
        {
            InitializeComponent();
        }

        private void Form1_Load_Load(object sender, EventArgs e)
        {
                int flow = 2147483647;
                textBox1.Text = Convert.ToString(flow + 1);
        }
    }
}

```
![참조1](/Media/Overflow.png "오버플로우 예제 결과")   

---

### 1-4) 연산자   
+ 산술 연산자
   +  +, -, *, /, %   
+ 할당 연산자   
   +  =, +=, -=, *=, /=, %=   
+ 증감 연산자   
   +  ++, --    
+ 논리 연산자   
   +  && (And), || (Or), | (Not)    
+ 관계/비교 연산자   
   +  <, >, ==, !=, >=, <=    
+ 비트 연산자   
   +  & (And), | (Or), ^ (XOr)    
   + 비트 내에서의 연산   
+ Shift 연산자   
   +  >>, <<    
   + 값을 이동시킬 수 있는 연산   
+ 조건 연산자   
   +  ?, ??   

**<연산자>**   

```ruby
namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 더하기");
            var p2 = 456; // 지역 변수로 만듦 [숫자 : int]
            Console.WriteLine(123+p2); // 579 [int + int] = int
            Console.WriteLine("123" + p2); // [string + int] = string / 문자열이 하나라도 있으면 문자열 결합으로 바뀜
            Console.WriteLine($"123{p2}"); // [string] / 위와 결과값 같음 지금 방식이 훨씬 편함 (C# 6.0 이후 문자열 만드는 방법)
            Console.WriteLine("123" + "456"); //[string + string] / 123456 [문자 : string]

            // 관계연산자
            int a = 30, b = 30;
            Console.WriteLine( a > b); //false (true,false 화면 출력시, 대문자로 바뀜)
            Console.WriteLine(a < b); // false
            Console.WriteLine( a >= b ); // true
            Console.WriteLine( a<=b ); //true
            Console.WriteLine( a == b ); //true
            Console.WriteLine(a != b); //false ( ! 는 '아니다'는 의미) 

            //논리 연산자
            Console.WriteLine("논리 연산자");
            Console.WriteLine( 10 > 9 && a > 0 );//true ('&&' 는 '그리고' 의미)
            Console.WriteLine( a > b || b > 0); // true ( || 는 '또는' 의미)
            Console.WriteLine(!(a < b)); //true

            // 조건연산자 단항 if 문을 대체 가능
            int c = 30;
            string result = c == 30 ? "삼십" : "삼십아님"; // = > 조건 연산자 써볼게 

            /*string result;
            if (c == 30)
                result = "삼십";
            else
                result = "삼십아님";*/

            Console.WriteLine(result);

            //병합연산자 (NULL 조건부 연산자)

            Console.WriteLine("NULL 병합연산자");
            int? d = null;
            Console.WriteLine($"{d}");

          
            

        }
    }
}
```
**<증감연산자>**   

```ruby
namespace IncDecTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("증감연산자 테스트");

            int result = 26;
            Console.WriteLine($"현재 숫자는 {result}");
            result += 3;
            Console.WriteLine($"현재 숫자는 {result}");
            result -= 10;
            Console.WriteLine($"현재 숫자는 {result}");

            Console.WriteLine($"현재 숫자는 {result++}");
            // ++result 와 result++ 랑 값변환 다름으로 위치 중요 (전치증감 / 후치증감)
            // ++result 는 + 먼저, result++ 는 값 먼저 주고 +를 뒷 작업으로 보냄
            Console.WriteLine($"전치감소 숫자는 {--result}");
            Console.WriteLine($"후치감소 숫자는 {result--}");
        }
    }
}
```

---

### 1-5) 배열(Array)   
```
배열이란?   
동일한 데이터 타입의 집합이다.   

쉽게 이야기를 해보자면,   
반복적인 코드 동작을 최대한 효율적으로 코드를 작성하기 위해 태어난 아이가 '배열'이다.
MBTI의 ENTJ가 가장 좋아하는 구성이다.
```

```ruby
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList( new[] { 80,74,81,90,34});

            var loc = array.IndexOf(81);
            array.Insert(loc, 50);

            Console.WriteLine("81위치에 50추가");
            foreach (var item in array)

            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("90 삭제");
            loc = array.IndexOf(90);

            array.RemoveAt(4);
            foreach (var item in array)

            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("정렬");
            array.Sort(); // 정렬
            foreach (var item in array)

            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
```
**<코드 예제 결과 값>**

![결과1](/Media/ArrayTest.png "배열 ")   

**알아두면 좋은 Array 클래스의 주요 메소드와 프로퍼티**   

+ 정적 메소드   
   + FindIndex<T>()   
         
      + 배열에서 지정한 조건에 부함하는 첫 번째 요소의 인덱스를 반환   
   + Resize<t>()    
     
      + 배열의 크기를 조정   
   + Clear()   
      + 배열의 모든 요소를 초기화   
   + ForEach<T>()   
      
      + 배열의 모든 요소에 대해 동일한 작업을 수행하게 함   

+ 인스턴스 메소드   
   + GetLength()   
      + 배열에서 지정한 차원의 길이를 반환   

+ 프로퍼티   
   + Length   
      + 배열의 길이를 반환   
   + Rank   
      + 배열의 차원을 반환   
 
**Arrat Code Example**   
```ruby   
 class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList( new[] { 80,74,81,90,34});

            var loc = array.IndexOf(81);
            array.Insert(loc, 50);

            Console.WriteLine("81위치에 50추가");
            foreach (var item in array)

            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("90 삭제");
            loc = array.IndexOf(90);

            array.RemoveAt(4);
            foreach (var item in array)

            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("정렬");
            array.Sort(); // 정렬
            foreach (var item in array)

            {
                Console.WriteLine($"{item}");
            }
        }
    }   
```   

```ruby   
static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"[{i} ,{j} ] : {arr[i,j]}\t");
                }

                Console.WriteLine("");
            }
        }   
```   

---

### 1-6) 코드 흐름의 제어   

```
프로그램의 흐름에 따라 제어할 수 있는 코딩이 존재한다   
```

+ 조건문     
+ 반복문   
+ 점프문   

### (1) 조건문 {if, else, switch}   

#### (1-1) if ~ else문  "만약에~ 그렇지 않으면"   
```ruby
namespace Chap05
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("수를 입력하세요 : ");
                string line = Console.ReadLine(); // 콘솔에서 입력값을 변수에 넣기 (할당)

                if(line == "quit") break; // quit 입력하면 프로그램 종료.

                int number = 0;
                int.TryParse(line, out number);  //int.Parse(line);
                //Console.WriteLine(number);
                //todo 아래 로직을 수정하세요
                if (number > 0 )
                {
                    if (number % 2 == 0)
                        Console.WriteLine("0보다 큰 짝수");
                    else
                        Console.WriteLine("0보다 큰 홀수");

                }
                else
                {
                    Console.WriteLine("0보다 작은 수");
                }
                // todo 마지막 
            }

            Console.WriteLine("계산종료!");
        }
    }
}
```   
**<if문 결과값>**   

![결과2](/Media/IfTestApp.png "if문")    

#### (1-2) switch, Label, Break
```
여러개 조건식의 결과를 검사한 후 프로그램의 흐름을 나눔
```

```ruby
namespace SwitchTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("요일을 입력하세요 : ");
                string line = Console.ReadLine(); // 콘솔에서 입력값을 변수에 넣기 (할당)

                if (line == "quit") break; // quit 입력하면 프로그램 종료.
                string day = line;

                /*if ( day == "월요일" )
                {
                    Console.WriteLine("월요일 입니다.");
                }
                else if (day == "화요일")
                {
                    Console.WriteLine("화요일 입니다.");
                }
                else if (day == "수요일")
                {
                    Console.WriteLine("수요일 입니다.");
                }
                else if (day == "목요일")
                {
                    Console.WriteLine("목요일 입니다.");
                }
                else if (day == "금요일")
                {
                    Console.WriteLine("금요일 입니다.");
                }
                else if (day == "토요일")
                {
                    Console.WriteLine("토요일 입니다.");
                }
                else if (day == "일요일")
                {
                    Console.WriteLine("일요일 입니다.");
                }
                else
                {
                    Console.WriteLine("요일이 아닙니다.");
                }*/

                switch (day)
                {
                    case "월요일":
                        Console.WriteLine("월요일 입니다.");
                        break;
                    case "화요일":
                        Console.WriteLine("화요일 입니다.");
                        break;
                    case "수요일":
                        Console.WriteLine("수요일 입니다.");
                        break;
                    case "목요일":
                        Console.WriteLine("목요일 입니다.");
                        break;
                    case "금요일":
                        Console.WriteLine("금요일 입니다.");
                        break;
                    case "토요일":
                        Console.WriteLine("토요일 입니다.");
                        break;
                    case "일요일":
                        Console.WriteLine("일요일 입니다.");
                        break;
                    default:
                        Console.WriteLine("요일이 아닙니다.");
                        break;
                        //if . else if. 문을 switch문으로 바꿀 수 있음 
                }

                Console.WriteLine("계산종료!");
            }
        }
    }
}
```   

**<switch문 결과값>**   

![결과3](/Media/SwitchTestApp.png "switch문 ")     

### (2) 반복문 {While, do, for, foreach}    

#### (2-1) While문 "값이 참일 때, 동안 반복할거야!"   
+ if문과 마찬가지로 true 또는 false가 반환되어야 함   
+ while문의 특징은 조건식이 참일 때 계속해서 반복하여 코드를 실행함    
+ 조건식이 거짓이 되면 루프를 빠져나옴   

**While문의 기본 형태**
```   
while (조건식) 
{
   //반복 실행될 코드
}   
```   

#### (2-2) do While문 "먼저 한번 실행 후 반복할거야!"   
```
do while 문의 주의사항!!   
조건식을 만족하든 만족하지 않든 반드시 한번은 실행이 됨!
```   

**do while문의 기본 형태**   
```
do 
{
   //반복 실행될 코드
}   
while 
(조건식);   
```   

#### (2-3) For문 "값이 참이될 때 까지 반복할거야!"   
+ while문과 큰 차이점은 없음   
+ for문이 확실히 코딩하기 간편함   
+ 초기식에는 반복을 실행하기 전 사용될 **변수를 초기화** 해야함   

**for문의 기본 형태**   
```
for(초기식; 조건식; 증감식;)
{
   //반복해서 실행될 코드
}
```   

#### (2-4) Foreach 문 "순화하며 차례대로 접근할거야!"   

+ 배열이나 컬렉션에서 주로 사용됨   
+ 여러개의 변수를 한 곳에 가져다가 붙인 형태   

**Foreach문의 기본 형태**   
```
foreach (변수 in 배열 혹은 컬렉션)
{
   //실행될 코드
}
```   

**Foreach문 코드 예제**   
```ruby   
namespace ForeachTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sources = { 1, 2, 3, 4, 5, 3, 6, 7, 8, 9, 10 };

           //for
            for (int i = 0; i < sources.Length; i++)
            {
                Console.WriteLine($"sources[i] = {sources[i]}");
            }
            //foreach
            Console.WriteLine("Foreach문");
            var idx = 0;
            foreach(var item in sources)
            {
                Console.WriteLine($"sources = { item}");
            }
        }
    }
}   
```   

#### (2-5) 반복문의 중첩 : 구구단    

**for문의 중첩**   
```
static void Main(string[] args)
{ 
   for (int a = 2; a < 10; a++) 
      {
         for (int b = 1; b < 10; b++) 
            {
               Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            } 
      }
}   
```   

**<구구단 결과 값>**   

![결과4](/Media/Foreach.png "구구단 ")   


### (3) 무한 루프와 제어문 {Infinite, Continue, Break, Goto}   

#### (3-1) 무한 루프 (Infinite loop)   

+ 종료문을 만나지 못하고 끝없이 동작하는 것   
+ 특정 문자가 입력되면 루프를 종료할 수 있음   

**무한 루프 기본 형태**   
```
while (true)
{
   // 값이 참이면 무한루프 시작
   //실행될 코드
}
```   

**Infinite loop 코드 예제**   
```ruby
namespace InfiniteLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 

            long idx = 0;
            for (; ; )//무한루프
            {
                Console.WriteLine($"idx = {idx++}");
            }
        }
    }
}
```   

#### (3-2) Break      

```
switch문에서 빠져나오기 위하거나 무한루프에서 빠져나오기 위해 사용됨   
```   

#### (3-3) Continue   

```
▶ 조건을 검사하는 부분으로 넘어가서 반복을 계속 수행하는 역할   
▶ continue를 만나면 바로 조건 검사부분으로 넘어감   
▶ 한번 쉬고 계속 반복을 진행   
```   

#### (3-4) Goto   

```
Goto는 해당 레이블로 뛰어넘어버리는 기능   
``` 

**Goto 기본 형태**   
```
...
goto 레이블;   

...
레이블 :   
   //실행될 코드   
...   
```   

---   

## 2. C# 객체지향 문법   

```
클래스 / 캡슐화 / 상속 / 다향성 / C#클래스 확장 / 멤버 유형 확장   
```   

### 2-1) Class  

#### (1) 클래스란?   
**코드 내의 모든 것을 객체로 표현하려는 패러다임**   
   + 객체(Object) : 세상의 모든 것을 지칭   

+ 객체의 표현   
   + 속성 : 데이터   
   + 기능 : 메소드   

+ 클래스 : 객체를 만들기 위한 청사진   
   + Ex) int a = 30;   
      + int : 클래스, 청사진   
      + a : 객체, int의 실체   

#### (2) 클래스의 선언과 객체 생성   

**클래스 선언 기본 형태**   
```
class 클래스 이름   
{
   //데이터와 메소드
}   
```   

#### (3) 생성자와 종료자   

+ 객체를 만드는 생성자   
   + 클래스와 같은 이름
   + 반환 형식 없음   

+ 객체를 파괴하는 종료자   
   + 클래스 이름 앞에 ~ 를 붙인 형태
   + 매게변수 X , 한정자 X   
   + 오버로딩 불가능   
   + 직접 호출할 수 없음   

**생성자와  코드 예제**   
```ruby   
class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체사용");

            /*cat cat1 = new cat(); //고양이 객체의 실체(instance) 생성
            cat1.Name = "야옹이";
            cat1.Color = "흰색";
            cat1.Meow();
            cat kitty = new cat();
            kitty.Name = "헬로키티";
            kitty.Color = "하얀색";
            kitty.Meow();
            cat nero = new cat();
            nero.Name = "검은 고양이 네로";
            nero.Color = "검은색";
            nero.Meow();*/

            cat yomi = new cat("요미", "흰색", "암컷");
            yomi.Meow();

        }
    }

    class cat //객체
    {
        public cat() { }

        public cat(string Name)
        {
            this.Name = Name; //this : 객체 자기 자신
        }

        public cat(string Name, string Color) : this(Name) //사용자 정의 생성자
        {
            this.Color = Color;
        }

        public cat(string Name, string Color, string Gender) : this(Name, Color)
        {
            this.Gender = Gender;
        }

        //속성, 특성, 변수
        public string Name; //이름
        public string Color; //색상
        public string Gender; //성별

        //행위, 기능, 메소드
        public void Meow()
        {
            Console.WriteLine($"{this.Name}(색상 {this.Color} / 성별 {this.Gender}) : 야옹!");
        }
    }   
```   

#### (3) 정적 필드와 정적 메소드   

+ static은 메소드나 필드가 클래스 자체에 소속되도록 지정하는 한정자   
+ 인스턴스 소속 필드 VS 클래스 소속 필드   
   + 클래스 소속된 필드 (Static) : 인스턴스를 만들지 않고 클래스의 이름을 통해 필드에 직접 접근   
+ 프로그램 전체에 공유 하는 변수에 사용함   

**정적 필드,메소드 사용 코드 예제**   
```ruby   
 class TestClass
    {
        public static int number;
        public float fnum;

        public static float ProcSomething()
        {
            Console.WriteLine($"{number}, 먼가를 한다.");
            return 1.0f;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestClass aCls = new TestClass();
            TestClass.number = 10;
            aCls.fnum = 3.25f;

            TestClass bCls = new TestClass();
            bCls.fnum = 4.87f;

            TestClass.ProcSomething();
        }


    }   
```   

#### (4) 객체 복사하기 : 얕은 복사 / 깊은 복사   

#### (5) 객체 자신을 지칭하는 This   
+ 객체 내부에서 자신의 필드나 메소드에 접근할 때 사용   

#### (6) 은닉성 (캡슐화)의 구현   
+ 감추고 싶은 것은 감추고, 보여주고 싶은 것만 보여줌   

**은닉성 코드 예제**   
```ruby   
namespace AccessModiFierTestApp

{   //접근 제한, 정보은닉 처리
    class Boiler
    {
        internal int temp = 5; //물 온도 //public>[protecte>private : 접근제한],internal (빈도 낮음)

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60) 
            {
                Console.WriteLine("물의 온도가 일정온도를 벗어났습니다.59℃ 맞춥니다.");
                this.temp = 59;
                return;
            } else
            {
                this.temp = temp; //온도 지정
            }
            
        }

        public int GetTemp(){
            return this.temp;
        }

        public void TurnOnBoiler() {
            Console.WriteLine("보일러를 켭니다.");
        }

        public void TurnOffBoiler() {
            Console.WriteLine("보일러를 끕니다."); 
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kiitturami = new Boiler();
            var currTemp = kiitturami.GetTemp ();
            Console.WriteLine($"현재온도는 {currTemp}℃ 입니다.");
            kiitturami.SetTemp(40);
            kiitturami.TurnOnBoiler();
            kiitturami.SetTemp(59);

            if (kiitturami.GetTemp() >= 59)
            {
                kiitturami.TurnOffBoiler();
            }
        }
    }
}   
```   

#### (7) Class 상속   

+ 부모 클래스와 자식 클래스 관계 파악 중요   

**상속 코드 예제**   
```ruby   
namespace InheritTestApp
{
    class Parent
    {
        protected string Name; // 부모 클래스의 속성 

        public Parent(string Name)
        {
            this.Name = Name; //Name 초기화
            Console.WriteLine($"{this.Name}Parent() 생성자"); //this Name에 parent를 생성하겠음
        }

        public void ParentMethod()
        {
            //...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }
    }

    // 자식클래스 만들게 (부모클래스 상속할거야)
    class Child : Parent
    {
        public String Color; //색상


        public Child(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Child() 생성자");
        }

        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행");
        }

        public void Getcolor()
        {
            Console.WriteLine($"{this.Name}의 색상 {this.Color}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent(" 부모 ");
            p.ParentMethod(); // 부모클래스 메서드 실행

            Child c = new Child("자식");
            c.ParentMethod(); //부모의 메서드 실행
            c.ChildMethod(); //자식 클래스 메서드 실행
            c.Color = "황색";
            c.Getcolor();

        }
    }
}
```   

#### (8) 기반클래스와 파생클래스 사이의 형식 "Welcome Zoom!"   
+ 기반클래스와 파생클래스 사이에 족보를 오르내리는 형식 변환 가능   
+ 자식클래스가 부모클래스의 인스턴스로 사용 가능   
+ 코드 수정 시 클래스 기반 내 필요한 작업   

**Zoom Code Example**   
```ruby  
namespace NewOverrideTestApp
{
    class Mammal //포유류
    {
        public string Name { get; set; }

        public void Breathe()
        {
            Console.WriteLine($"{this.Name}이(가) 숨을 쉰다.");
        }

        /*public void Move()
        {
            Console.WriteLine($"{this.Name}이(가) 이동한다.");
        }*/

        public virtual void Move()
        {
            Console.WriteLine($"(부모작업){this.Name}이(가) 이동한다.");
        }
    }

    class Dog : Mammal
    {
        /* public void Move()
         {
             Console.WriteLine($"{this.Name}이(가) 네 발로 달린다.");
         }
 */

        public override void Move()
        {
            base.Move(); //부모에 있는 Move 실행
            Console.WriteLine($"{this.Name}이(가) 네 발로 달린다."); //+alpha 실행
        }
    }

    class Huamn : Mammal
    {
        public new void Move()
        {
            //부모의 메서드 숨긴다
            Console.WriteLine($"{this.Name}이(가) 두 발로 움직인다.");
        }
    }

    class Whale : Mammal //고래
    {
        public override void Move()
        {//부모의 메서드를 재정의 
            Console.WriteLine($"{this.Name}이(가) 지느러미로 헤엄친다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog ppopi = new Dog();
            ppopi.Name = "뽀삐";
            ppopi.Move();

            Huamn Edun = new Huamn();
            Edun.Name = "Edun";
            Edun.Move();

            Whale whale = new Whale();
            whale.Name = "고래";
            whale.Move();
        }
    }
}
```   

#### (9) is와 as {C#의 형 변환 연산자}   

+ is   
   + 객체가 해당 형식에 해당하는 검사 후 bool값으로 변환   
+ as   
   + 형식 변환 연산자와 같은 역할   
   + 참조 형식에만 사용   
   + 변환에 실해시, 객체 참조를 null로 만듦   

**TypeCasting Code Example**   
```ruby   
namespace ClassTypeCastApp
{ //형변환
    class 포유류
    {
        public void 키우다 ()
        {
            Console.WriteLine("키우다()");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍!");
        }
    }

    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            포유류 _포유류 = new 포유류();
            _포유류.키우다();

            // 자식이 부모클래스로 변환 [묵시적 변환]
            _포유류 = new 강아지();
            _포유류.키우다();
            강아지 쭈쭈;

            if (_포유류 is 강아지)
            {
                쭈쭈 = _포유류 as 강아지;
                쭈쭈.멍멍();
            }

            /*_포유류 = new 고양이();
            _포유류.키우다();
            _포유류.야옹(); => 에러*/



            // [명시적 변환]부모가 자식클래스로 변환 : 들어간다라고 자식을 불러줘야함
            // 근데 명시적 변환은 쓸모 없음. 실행자체가 안됨.
            강아지 뽀삐 = null;
                if (뽀삐 is 포유류)
            {
                Console.WriteLine("이 부분이 실행됩니다.");
                뽀삐 = new 포유류() as 강아지;
                뽀삐.키우다();
                뽀삐.멍멍();
            }
          
            /*고양이 로미 = (고양이) new 포유류();
            로미.키우다();
            로미.야옹();*/

        }
    }
}   
```   

#### (10) Tuple    
+ 여러 필드를 담을 수 있는 구조체   
   + 형식의 이름을 갖지 않음   
    + 임시적으로 사용할 복합 데이터 형식 선언에 적합
```ruby

class Program
    {
        static void Main(string[] args)
        {
            var tuple1 = (1, "박효진", "010-8845-2413", "김해시 계동로", true);

            var tuple2 = (Idx: 2, Name: "홍길동", Phone: "010-9999-9999", Address: "경남 창원시 의창구", Marrige: false);

            Console.WriteLine($"{tuple1.Item1} / {tuple1.Item2} / {tuple1.Item3} / {tuple1.Item4} / {tuple1.Item5}");
            Console.WriteLine($"{tuple2.Item1} / {tuple2.Item2} / {tuple2.Item3} / {tuple2.Item4} / {tuple2.Item5}");
            Console.WriteLine($"{tuple2.Idx} / {tuple2.Name} / {tuple2.Phone} / {tuple2.Address} / {tuple2.Marrige}");
        }
    }   
```   

#### (11) Class VS Struct(구조체)   
+ Class   
   + 참조 형식
   + 얕은 복사 (Shallow Copy)   
   + new 연산자와 생성자 필요   
   + 매개 변수 없는 생성자 선언 가능   
   + 상속 가능   

+ Struct   
   + 값 형식   
   + 깊은 복사 (Deep Copy)   
   + 선언 만으로도 생성 가능   
   + 매개 변수 없는 생성자 선언 불가능   
   + 모든 구조체는 System.Object형식을 상속하는    
      System.Value Type으로부터 직접 상속 받음   
      
#### (12) 한 눈에 정리하는 Class 예제!   
```ruby   
public class MyCustomer
{
    // 필드
    private string name;
    private int age;

    // 이벤트 
    public event EventHandler NameChanged;

    // 생성자 (Constructor)
    public MyCustomer()
    {
        name = string.Empty;
        age = -1;
    }

    // 속성
    public string Name
    {
        get { return this.name; }
        set 
        {
            if (this.name != value)
            {
                this.name = value;
                if (NameChanged != null)
                {
                    NameChanged(this, EventArgs.Empty);
                }
            }                
        }
    }
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    // 메서드
    public string GetCustomerData()
    {
        string data = string.Format("Name: {0} (Age: {1})", 
                    this.Name, this.Age);
        return data;
    }
}   
```   

---   

### 2-2) 인터페이스와 추상 클래스   

+ 인터페이스   
   + 인터페이스는 클래스가 따라야 하는 **약속** 이다   
   + Class는 자기자신을 상속하지 못하기에 쓰이는 인터페이스
   + 인터페이스를 상속하느 인터페이스   
      + 기존 인터페이스에 새로운 기능을 추가한 인터페이스를 만들고 싶을 때   
      + 필요한 인터페이스가 어셈블리로만 제공되는 경우   
      + 필요한 인터페이스를 상속한 클래스가 있는 경우   

+ 추상 클래스   
   + 구현을 가지되 인스턴스는 갖지 못함   
   + 클래스의 접근성에 사용됨   
   + 다른 추상클래스 상속 가능   
      + 자식 추상 클래스에서 부모의 추상 메소드 구현의무는 없음   

**인터페이스와 추상 클래스 코드 예제**   
```ruby
namespace InterfaceTestApp
{
    /*class Ridable //탈것
    {
        public void Ride()
        {
            Console.WriteLine("탈 것!");
        }
    }*/

    interface ICar
    {
        void Run();
        void Ride();
    }

    interface IPlane
    {
        void Fly();

        void Ride();

    }

    class DroneCar : IPlane, ICar
    {
        public void Fly()
        {
            Console.WriteLine("드론카 날다!");
        }

        public void Ride()
        {
            Run();
            Fly();
        }

        public void Run()
        {
            Console.WriteLine("드론카 달리다!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DroneCar dreamCar = new DroneCar();
            dreamCar.Ride();
        }

    }
}
```   

```ruby   
namespace LoggerTestApp
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }

    interface IFormattableLogger : ILogger    // 인터페이스의 상속 
    {
         void WriteLog(string format, params object[] args);
    }

    class ConsoleformatLogger : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleLogger");
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그메시지");

            IFormattableLogger logger2 = new ConsoleformatLogger();
            logger2.WriteLog("{0} * {1} = {2}", 3, 4, 12);
        }
    }
}
```   

```ruby   
namespace MultiInterfaceApp
{
    interface IRunnable // 자동차 종류
    {
        void Run();
    }

    interface IFlyable // 비행기 종류
    {
        void Fly();
    }

    class DroneCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날아가자!");
        }

        public void Run()
        {
            Console.WriteLine("달리자!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카!");

            DroneCar DreamCar = new DroneCar();
            DreamCar.Run();
            DreamCar.Fly();

            Console.WriteLine("자동차로 변경 (interface)");
            IRunnable car = DreamCar as IRunnable;
            car.Run();
            //car.Fly(); //erro

            Console.WriteLine("비행기로 변경(interface)");
            IFlyable plane = DreamCar;
            plane.Fly();
            //plane.Run();//erro

        }
    }
}    
```   

---

### 2-3) 메소드 (Method)   

#### (1) 메소드 (Method)   

+ 메소드란?   
   : 일련의 코드를 하나의 이름 아래 묶은 것     
      + C와 C++의 함수와 비슷한 기능   
      + 클래스 내에서 일련의 코드 블럭을 실행시키는 함수   
      + 0 ~ N개의 인수를 가지고 있음   
      + 하나의 리턴 값을 가지고 있음   
      + 리턴 값이 없으면 리턴 타입을 void로 표시      

+ 메소드의 접근 지정자   
   + private   
   + public   
   + protected   
      + 접근 가능한 범위를 지정   
      
**메소드 기본 예제**   
```
 class Calculator
    {
        static void Main(string[] args)
        {
            int x = Calculator.Plus(3, 4);
            int y = Calculator.Plus(5, 6);
            int z = Calculator.Plus(7, 8);

            int result = x + y + z;
            Console.WriteLine($"결과는 {result}");
        }

        private static int Plus(int p1, int p2)
        {
            // throw new NotImplementedException();
            Console.WriteLine($"Input : {p1}, {p2}");
            int result = p1 + p2;
            Console.WriteLine($"Output : {result}");
            return result;
        }
    }   
```   

#### (2) Ref와 Out   

+ ref   
   + 변수값을 그대로 전달 X → 변수의 메모리 주소를 전달 O   
   + 변수를 전달하기 전 초기화 해야함   
   
+ out   
   + ref와 비슷하게 인수를 참조로 전달할 때 사용   
   + 초기화 하지 않고도 전달 가능   

**Ref와 Out 코드 예제**   
```ruby   
  class Program
    {
        static void Main(string[] args)
        {
            int a = 22, b = 3;
            int val = 0;
            int rem = 0;
            Divide(a, b, out val, out rem);

            Console.WriteLine($"{a},{b} : a/b = {val}, a%b = {rem} ");

            bool isSucced = int.TryParse("1000.74", out int result);
            Console.WriteLine($"변환결과{isSucced} , result값 {result}");
            

        }

        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }   
```   

#### (3) 메소드 오버로딩   

+ 하나의 메소드 이름에 여러 개의 구현을 올리는 것   
+ 매개 변수의 수와 형식을 분석해 호출할 메소드 결정   
+ 이름에 대한 고민을 덜어줌   
+ 코드의 일관성을 제공   
+ 똑같은 메소드 명에 매개변수에 따라 호출되는 메소드가 다름   

**오버로딩 메소드 기본 예제**   
```
class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기!");

            int x = Calculator.Plus(3,4);
            Console.WriteLine($"3 + 4 = {x}");

            float y = Calculator.Plus(3.14f, 5.6f);
            Console.WriteLine($"3.14 + 5.6 = {y}");
            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, 5.6)}");
            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, "5")}");
            int z = Calculator.Plus(7,8,9);

            
            // [가변길이 매개변수]밑에것처럼 쓰면 매개변수 쓰기 짱 편해! 
            int total = 0;
            total = sum(1,2, 4, 8, 24);
            Console.WriteLine($"합계는 {total}");
            Console.WriteLine($"10까지의 합은 {sum(1,2,3,4,5,6,7,8,9,10)}");

            int[] arrs = new int[] {1,2,3,4,5,6,7,8,9,10 };
            Console.WriteLine($"10까지의 합은 {sum(arrs)}");
        }

        private static int Plus(int v1, int v2, int v3)
        {
            int result = v1 + v2 + v3;
            return result;
        }

        private static int sum(params int [] args)
        {
            int result = 0;
            foreach (var arg in args)
            {
                result += arg;
            }
            return result;
        }


        private static double Plus(double v1, string v2)
        {
            double.TryParse(v2, out double p2);
            double result = v1 + p2;
            return result;
        }

        private static double Plus(double v1, double v2)
        {
            double result = v1 + v2;
            return result;
        }

        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            return result;
        }

        private static int Plus(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }
    }
    
```   
    
#### (4) 명명된 매개변수와 선택적 매개변수   

```ruby   
 class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("박효진", "010-8845-2413");

           if( PrintProfile(null, "010-1111-2222") == -1);
            {
                Console.WriteLine("프로필 출력 시 오류가 발생했습니다.");
            }

            //[명명된 매개변수 - "",] 가독성에 짱 좋음!
            /*PrintProfile(phone:"010-1708-3826", name: "홍길동");
            PrintProfile(name:"홍길순", phone : "010-2708-3878" );*/
            
            //[선택적 매개변수 ] 순서중요! 뒤에서부터 값이 입력이 되어야만 가능
            PrintProfile("최백호");
        }
        public static int PrintProfile (string name, string phone = "010-8845-2413") // voide 쓸 때와 int 쓸 때와 다른 것을 인지해야 함
        {    if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세요.");
                return -1;
            }

            //프로필 출력
            Console.WriteLine($"이름 : {name}, 폰 번호 : {phone}");
            return 0;
        }
    }   
```   

#### (5) Swap메소드   
   + 정렬할 때 쓰이는 메소드 
   + DB의 ordeby, desc, esc와 같음   

```ruby   
class Program
    {
        static void Main(string[] args)
        {
            int x = 47, y = 5;
            Console.WriteLine($"Before Swap {x},{y}");
            Program.Swap(/*ref*/ x, /*ref*/ y); //정렬 기반

            Console.WriteLine($"After Swap {x},{y}");
        }

        private static void Swap(/*ref*/ int p1, /*ref*/ int p2) //refurence : 주소 
        // Swap 메소드 : 정렬할 때 쓰임 ( DB 의 orderby, desc, esc 와 같음) 
        {
            int temp = p1; // temp 47 이 들어온겨 
            p1 = p2; // p1 = 5, p2 =5 
            p2 = temp; // p2 = 47
        }
    }
```   

---   

### 2-4) 프로퍼티 {캡슐화의 프로퍼티}   

#### (1) 프로퍼티란?   

**Public의 관대함**   
+ 할당연산자(=)를 이용한 필드 액세스의 간편함   
   + 데이터의 오염 가능성이 높아짐!!!   

+ Get/SEt 메소드를 사용한 필드 은닉   
   + 번거롭고 귀찮음!!   

∴ 은닉성과 편의성 두마리 토끼를 다 잡는 방법 = **프로퍼티**   

**프로퍼티 코드 예제**   
```ruby   
namespace PropertyTestApp
{
    class Myclass
    {
        private int iValue; // 0~120℃ 값만 입력받는 멤버 변수
        private double dZeta;
        private float fPng;
        private string strVal;
        private int inCode;

        public int IValue 
        {
            get {
                return this.iValue;
            }
            set {
                if (value < 0)
                    this.iValue = 0;
                else if (value > 120)
                    this.iValue = 120;
                else
                    this.iValue = value;
                
            }
        }

        public Myclass(int iValue)
        {
            IValue = iValue;
            //this.SetValue (iValue);
        }

       /* public int GetValue()
        {
            return this.iValue;
        }
        public void SetValue(int iValue)
        {
            if (value < 0)
            {
                this.iValue = 0;
            }
            else if (iValue > 120)
            {
                this.iValue = 120;
            }
            else
            {
                this.iValue = iValue;
            }
        }*/

        public void PrintValue()
        {
            Console.WriteLine($"값은 {this.iValue}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass(1200);
            myclass.PrintValue();

            //myclass.SetValue(108);
            myclass.IValue = 1200;
            myclass.PrintValue();
            //Console.WriteLine($"현재 온도는 {myclass.GetValue()}℃ 입니다.");
            Console.WriteLine($"현재 온도는 {myclass.IValue}℃ 입니다.");
        }
    }
}   
```   

#### (2) 자동 구현 프로퍼티   

+ 단순히 필드를 읽고 쓰기만 하는 경우에 사용  
+ 선언 동시에 초기화   

**프로퍼티 최종 코드 예제***   

```ruby   
namespace PropertyTestApp2
{
    //생일정보 클래스
    
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public DateTime Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public DateTime GetBirthday()
        {
            return this.birthday;
        }

        public void SetBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo info = new BirthdayInfo();
            info.SetName("홍길동");
            info.SetBirthday(new DateTime(1990,1,8));

            Console.WriteLine($"이름 : {info.GetName()}");
            Console.WriteLine($"생일 : {info.GetBirthday()}");

            Console.WriteLine("프로퍼티 사용");

            BirthdayInfo info2 = new BirthdayInfo();
            info2.Name ="홍길순";
            info2.Birthday= new DateTime(1992, 3, 26);

            Console.WriteLine($"이름 : {info2.Name}");
            Console.WriteLine($"생일 : {info2.Birthday}");
        }
    }
}   
```   

### 2-2) 일반화 프로그래밍 - Generic과 실무사용 컬렉션   

#### (1) 일반화 프로그래밍이란?   
+ 일반화   
   + 특수한 개념으로 부터 공통된 개념을 찾아 묶는 것   

+ 일반화 프로그래밍   
   + 일반화의 대상 - 데이터 형식   

**일반화 프로그래밍 코드 예제**   

```ruby   
namespace Chap11App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56}; //5개 int 배열
            int[] target = new int[source.Length]; //5개 int 배열 초기화

            CopyArray(source, target);//int 배열 복사
            Console.WriteLine("배열복사");
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯"};
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);
            Console.WriteLine("strin 복사");
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }

            float[] source3 = { 1.1f, 2.2f, 3.3f, 4.5f, 6.6f};
            float[] target3 = new float[source3.Length];
            Console.WriteLine("float 배열 복사");
            foreach (var item in target3)
            {
                Console.WriteLine(item);
            }
        }

        private static void CopyArray(string[] source2, string[] target2)
        {
            for (int i = 0; i < source2.Length; i++)
            {
                target2[i] = source2[i];
            }
        }

        private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}   
```   

**Generic Code Example**   
```ruby   

namespace GenericClassApp
{
    class Array_Generic<T>
    {
        private T[] array;

        public Array_Generic()
        {
            array = new T[10];
        }

        public T GetElement(int index) { return array[index]; }

        public int Length
        {
            get { return array.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Array_Generic<int> array = new Array_Generic<int>();

            Array_Generic<string> str = new Array_Generic<string>();
        }
    }
}   
```   

**GenericCopyArray Code Example**   
```ruby   
 static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56 }; //5개 int 배열
            int[] target = new int[source.Length]; //5개 int 배열 초기화

            CopyArray(source, target);//int 배열 복사
            Console.WriteLine("배열복사");
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);
            Console.WriteLine("strin 복사");
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }
        }

        private static void CopyArray<T>(T[] source, T[] target)
        { //<T>, <P> ' 어떤 타입(파라미터)이던 다 받아 들이겠다 ' 
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
```   

**실무 사용 코드 예제1**   
```ruby   
namespace GenericListApp
{
    class Program
    {

        //가장 실무에서 많이 사용되는 컬렉션 1 
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6};
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
            list.Reverse();
            Console.WriteLine("Descending(역정렬)");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            list.Insert(3,20);
            Console.WriteLine("값 추가");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            list.RemoveAt(5);
            Console.WriteLine("값 삭제");
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            List<string> strList = new List<string>() { "일", "이", "삼", "사", "오"};
            Console.WriteLine("문자열 리스트");
            foreach (var item in strList)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
```   

**실무 사용 코드 예제2**   
```ruby   
namespace DictionaryApp
{
    class Program
    {
        //실무에서 많이 쓰는 컬렉션 2
        static void Main(string[] args)
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>() {
                { 1,"One"}, { 2, "Two"}, { 3,"Three"}, { 4, "Four"}, { 5, "Five"} };
           /* pairs[1] = "One";
            pairs[2] = "Two";
            pairs[3] = "Three";
            pairs[4] = "Four";
            pairs[5] = "Five";*/

            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Dictionary<string, string> pairs2 = new Dictionary<string, string>() { };
            pairs2 ["일"] = "One";
            pairs2 ["이"] = "Two";
            pairs2 ["삼"] = "Three";
            pairs2 ["사"] = "Four";
            pairs2 ["오"] = "Five";

            foreach (var item in pairs2)
            {
                Console.WriteLine(item);
            }

        }

    }
}
```   

### 2-5) 예외 처리하기   

#### (1) 예외에 대해   

+ 예외 : 개발자가 생각하는 시나리오에서 벗어나는 사건   
+ 예외 처리 : 프로그램의 오류나 다운으로 이어지지 않도록 처리   

#### (2) Try ~ Catch로 예외 받기   

+ 발생한 예외를 받아서 처리해줌   
+ 메커니즘   
   + try절에 실행하고자 했던 코드를 처리   
   + 예외(if여러개)가 던져지면 catch블록 (여러개)에서 받아서 처리!   

**Try Catch 문 코드 예제**   
```ruby   

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i}번째 값 : {arr[i]}");
                }
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            Console.WriteLine("나머지 일처리 계속...");
            int x = 108, y = 0;
            int result = 0;

            try
            {
                result = x / y;
                Console.WriteLine($"결과는 {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            Console.WriteLine(" 또 나머지 일처리 계속...");
        }
    }
}
```   

#### (3) Throw문 "입벌려, 예외들어간다!"   

+ throw문   
   : 예외를 던지는 방법   
+ 메소드 내에서 예외를 던질 경우, 메소드를 호출한 Try ~ Catch문에서 받음   

#### (4) Try ~ Catch와 Finally   
**자원 해제같은 뒷마무리를 담당함**   

**Finally절 코드 예제**

```ruby
namespace TryCatchFinallyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("제수를 입력하세요 : ");
                string temp = Console.ReadLine(); //string으로 입력받음
                int divisor = int.Parse(temp);

                Console.Write("피제수를 입력하세요 : ");
                temp = Console.ReadLine();
                int divdend = int.Parse(temp);

                Console.WriteLine($"{divisor} / {divdend} = {Divide(divisor, divdend)}");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"미 구현 예외발생 : {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"입력값 예외!! : {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"나누기 예외발생 : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("예외 발생 유무와 상관없이 늘 실행! try문 내 리소스 해제...");
            }
        }

        private static object Divide(int divisor, int divdend)
        {
            Console.WriteLine("나누기 시작!");
            if (divdend == 0) throw new DivideByZeroException("피제수가 0이 입력되었습니다.");
            return divisor / divdend;
        }
    }
}   
```   

#### (5) 사용자 정의 예외 클래스   
+ 특별한 데이터를 담아서 예외 처리 루틴에 추가 정보 제공   
+ 예외 상황 설명을 더 잘하고 싶을 때 사용   

**Exception Code Example**   

namespace ExceptionThrowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               DoSomething(13);

            }
            catch (Exception ex)
            {

                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
        }

        private static void DoSomething(int v)
        {
            
                if (v <= 10)
                {
                    Console.WriteLine($"V^2 = {v * v}");
                }
                else
                {
                    throw new Exception("10보다 큰 값은 계산할 수 없습니다.");
                }
           
        }
    }
}   

---   

### 2-6) 대리자와 이벤트   

#### (1) 대리자란?   

+ 콜백   
   : 대신 어떤 일을 해줄 코드를 두고 실행 시점에 부여   
   
+ 콜백을 구현하는 방법 = 대리자   

+ 메소드에 대한 참조를 하는 대리자   
   + 대리자에 메소드의 주소를 할당   

**대리자 호출 코드 예제**   
```ruby   
namespace Chap13App
{
    delegate int MyDelegate(int a, int b); //대리자. 대신 호출한다.
    class Calculator
    {
        public int Plus (int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate callback;

            callback = new MyDelegate(calc.Plus);
            Console.WriteLine($"result = {callback(3,4)}");
        }
    }
}   

```   

#### (2) 대리자 사용 이유와 시기   

+ "값"이 아닌 "코드"자체를 매게변수로 넘기고 싶을 때 
+ 대리자 사용 사례   
   + 대리자 선언   
   + 대리자가 참조할 비교메소드 작성   
   + 정렬할 배열과 대리자를 매개변수로 받는 정렬 메소드 작성   
   + 정렬 메소드 호출   

**대리자 코드 예제2**   
```ruby   

namespace CallbackTestApp
{
    delegate int Compare(int a, int b); // a, b 비교 대리자.

    class Program
    {
        // 오름차순 a가 b보다 크면 1리턴, 같으면 0리턴, a < b이면 -1리턴
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1; // a, b를 바꿀것
            else if (a == b) return 0;
            else return -1;
        }

        // 내림차순 비교, a<b이면 1리턴, 같으면 0, a>b -1리턴
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1; // b와 a를 순서 바꿀것
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbleSort(int[] DataSet, Compare comparer)
        {
            int temp = 0;
            for (int i = 0; i < DataSet.Length; i++)
            {
                for (int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    // 비교하여 값 위치변경 Swap
                    if (comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 8, 4, 2, 1, 10 };

            Console.WriteLine("Sorting....");
            BubbleSort(array, new Compare(DescendCompare)); // 오름(내림)차순 정렬
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}   
```   

#### (3) Delegate {익명 메소드}   

```ruby   
namespace DelegateChainApp
{
    delegate void AllCalc(int x, int y); //대리자 선언
    class Program
    {
        static void Plus (int a, int b) { Console.WriteLine($"a + b = {a+b}"); }
        static void Minus(int a, int b) { Console.WriteLine($"a - b = {a - b}"); }
        static void Multiple(int a, int b) { Console.WriteLine($"a * b = {a * b}"); }
        static void Divide(int a, int b) { Console.WriteLine($"a / b = {a / b}"); }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating!");
            AllCalc allCalc = Plus;
            allCalc += Minus;
            allCalc += Multiple;
            allCalc += Divide;

            allCalc(10, 5);

            /*Plus(10, 5);
            Minus(10, 5);
            Multiple(10, 5);
            Divide(10, 5);*/

            Console.WriteLine("뺄셈 메서드 제거");
            allCalc -= Minus;
            allCalc(10, 5);
        }
    }
}   
```   

#### (4) 이벤트   

+ 이벤트 : 객체에서 일어난 사건 알리기   
   + 어떤 일이 생겼을 때 알려주는 객체를 만들 때 사용   
   + 이벤트 사용 절차   
      + 대리자 선언
      + 선언한 대리자 인스턴스를 event 한정자로 수식   
      + 이벤트 핸들러 작성   
      + 클래스 인스턴스 생성 후 객체의 이벤트에 이벤트 핸들러 등록   
      + 이벤트 발생 및 핸들러 호출   

**이벤트 코드 예제**   
```ruby   
namespace UsingEventApp
{
    delegate void EventHandler(string message); //메시지 받아서 처리하는 대리자 선언 
    class CustomNotifier
    {//이벤트 선언, 사용하는 객체
        public event EventHandler SomethingHappened;

        public void Dosomething (int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened($"{number} : 짝 !");
            }
        }
    }
    class Program
    {
        //이벤트가 발생했을 때 실행되는 메서드 (이벤트 핸들러)
        public static void MyHandler (string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 0; i <= 100; i++)
            {
                notifier.Dosomething(i);
            }
        }
    }
}   
```   

---   

### 2-6 LINQ {from, where, orderby, select}   

#### (1) C#언어에 통합된 데이터 질의 기능   

#### (2) 내부 조인과 외부 조인   
+ 각 데이터 원본 특정 필드 값을 비교해 일치하는 데이터끼리 연결   
+ 내부조인 : 교집합   
+ 외부조인 : 기준이 되는 데이터 원본 모두 포함   

**LINQ Code Example**   
```ruby   
namespace Chap15App
{
    class Profile
    {
        public string Name { get; set; }
        public short Height { get; set; }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 }; // 10개 배열
            // LINQ안쓰는 방식
            /*List<int> result = new List<int>();
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }
            result.Sort();*/
            // LINQ쓰는 방식
            var result = from item in numbers
                         where item % 2 == 0
                         orderby item
                         select item;

            foreach (var item in result)
            {
                Console.WriteLine($"짝수 : {item}");
            }

            List<Profile> profiles = new List<Profile>
            {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하하", Height = 171 }
            };

            List<Product> products = new List<Product>
            { 
                new Product() { Title = "비트", Star = "정우성" },
                new Product() { Title = "CF다수", Star = "김태희" },
                new Product() { Title = "아이리스", Star = "김태희" },
                new Product() { Title = "모래시계", Star = "고현정" },
                new Product() { Title = "솔로예찬", Star = "이문세" },
            };

            var resProfiles = from item in profiles
                              where item.Height < 175
                              orderby item.Height ascending /*descending*/
                              select new
                              {
                                  Name = item.Name,
                                  Height = item.Height,
                                  InchHeight = item.Height * 0.393
                              };

            foreach (var item in resProfiles)
            {
                Console.WriteLine($"{item.Name}, {item.Height}cm, {item.InchHeight}inch");
            }

            var resProfiles2 = from item in profiles
                              where item.Height < 175
                              orderby item.Height ascending /*descending*/
                              select item.Height;

            foreach (var item in resProfiles2)
            {
                Console.WriteLine($"{item}");
            }

            // group by
            var resProfiles3 = from item in profiles
                               orderby item.Height
                               group item by item.Height < 175 into g
                               select new { 
                                   GroupKey = g.Key, Items = g
                               };

            foreach (var group in resProfiles3)
            {
                Console.WriteLine($"175cm 미만 그룹 : {group.GroupKey}");

                foreach (var item in group.Items)
                {
                    Console.WriteLine($"    {item.Name}, {item.Height}cm");
                }
            }

            // inner join
            var joinProfiles = from p in profiles
                               join d in products
                               on p.Name equals d.Star
                               select new
                               {
                                   Name = p.Name,
                                   Work = d.Title,
                                   InchHeight = p.Height * 0.393
                               };
            Console.WriteLine("내부 조인 결과!");
            foreach (var item in joinProfiles)
            {
                Console.WriteLine($"이름:{item.Name}, 작품:{item.Work}, 키:{item.InchHeight}inch");
            }

            // outer join
            var joinProfiles2 = from p in profiles
                               join d in products
                               on p.Name equals d.Star into ps
                               from d2 in ps.DefaultIfEmpty(new Product() { Title ="작품없음" })
                               select new
                               {
                                   Name = p.Name,
                                   Work = d2.Title,
                                   InchHeight = p.Height * 0.393
                               };
            Console.WriteLine("외부 조인 결과!");
            foreach (var item in joinProfiles2)
            {
                Console.WriteLine($"이름:{item.Name}, 작품:{item.Work}, 키:{item.InchHeight}inch");
            }
        }
    }
}   
```   

---   

### 2-7) 스레드와 태스크   

#### (1) 프로세스와 스레드   

+ 프로세스   
   + 실행 파일이 실행되어 메모리에 적재된 인스턴스   
   + 하나 이상의 스레드로 구성   

+ 스레드   
   + 운영체제가 CPU 시간을 할당하는 기본 단위   

+ 멀티 스레드의 장점   
   + 사용자 대화형 프로그램에서 응답성을 높일 수 있음   
   + 경제성 : 메모리와 자원을 할당하는 비용 절감   
   + 멀티 프로세스 방식에 비해 멀티 스레드 방식 자원 공유가 쉽다   

+ 멀티 스레드의 단점   
   + 구현하기 까다랍고 테스트가 쉽지 않음   
   + 과다한 사용 = 성능 저하 야기   
   + 자식 스레드의 문제 발생 시 전체 프로세스에 영향을 끼침   

**스레드 코드 예제**   
```ruby   

namespace Chap19App
{
    class Program
    {
        static void Dosomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10); // 1/100초 동안 멈추게함 
            }
        }
        static void SomthingHappened()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10); // 1/100초 동안 멈추게함 
            }
        }
        static void Main(string[] args)
        {
           

            Thread thread = new Thread(new ThreadStart(Dosomething));
            Thread thread1 = new Thread(SomthingHappened);

            try

            {
                Console.WriteLine("스레드 시작!");
                thread.Start();
                thread1.Start();

                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Main thrad : {i}");
                    Thread.Sleep(10);

                    if (i == 10)
                        thread.Abort();
                }


                Console.WriteLine("스레드 종료 대기...");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            finally
            {
                thread.Join();
                thread1.Join();

                Console.WriteLine("프로세스 종료");
            }
        }
    }
}
```   

#### (2) 스레드 임의 종료 시키기   

+ Thread 객체의 Abort()메소드 사용   
+ 권장하지 않음   
   + 자원을 독점한 스레드가 해제 못한 상태로 Abort의 희상양이되어짐   
   + 꼭 해야하는 상황이라면 도중에 강제로 중단해도 프로세스에 영향주지 않는 작업으로 진행   

**스레드 임의 종료 코드 예제**   
```ruby   
namespace SideTaskApp
{
    class SideTask
    {
        int Count { get; set; }

        public SideTask(int count)
        {
            this.Count = count;
        }

        public void CountDown()
        {
            try
            {
                while (Count > 0)
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {Count} 남음");
                    Count--;
                    Thread.Sleep(10);
                }
                Console.WriteLine($"Count : {Count}"); //결과는 0 

            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine($"스레드 임의종료 예외발생 : {ex.Message}");
                Thread.ResetAbort();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"스레드 예외발생 : {ex.Message}");
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread th = new Thread(task.CountDown);
            th.IsBackground = false; // 이 스레드가 종료되기 전까지는 모든 프로세스가 끝나지 않음
            // true인 경우, 백그라운드 스레드가 돌고있는 상태에도 메인스레드가 끝나면 백그라운드 스레드도 같이 종료
            SideTask task2 = new SideTask(200);
            Thread th2 = new Thread(task2.CountDown); // 기본값 IsBackground false


            Console.WriteLine("스레드 시작!");
            th.Start();
            th2.Start();

            Thread.Sleep(1000); // 1초 슬립

            Console.WriteLine("인터럽트!");
            th2.Interrupt(); ; //인터럽트 
            Console.WriteLine("임의 종료!");
            //th.Abort();

            Console.WriteLine("종료 대기"); // 카운트다운 중간에 표시
            th.Join();
            th2.Join();

            Console.WriteLine("스레드/프로세스 종료!");
        }
    }
}   
```   

#### (3) 태스크 Task   

+ 멀티 코어 시대 고성능 소프트 웨어 개발   
   + 병렬 처리 기법과 비동기 처리 기법   

+ 예제를 통한 이해도 상승 필요   

**태스크 코드 예제**   
```ruby   
namespace ThreadStateApp
{
    class Program
    {
        static void PrintState(ThreadState state)
        {
            Console.WriteLine($"{state, 16} : {(int) state}");
        }
        static void Main(string[] args)
        {
            PrintState(ThreadState.Running);
            
            PrintState(ThreadState.StopRequested);
            PrintState(ThreadState.Stopped);
            PrintState(ThreadState.SuspendRequested);
            PrintState(ThreadState.Suspended);
            PrintState(ThreadState.Unstarted);
            PrintState(ThreadState.WaitSleepJoin);
            PrintState(ThreadState.AbortRequested);
            PrintState(ThreadState.Aborted);
        }
    }
}
```    

---   

### 2-8 ) C#으로 만드는 Winform   

```
지금까지 배운 C# 기초와 문법으로 WinForm 윈도우와 Application 을 구현해 나갈 것입니다.   
생각과 마음의 거리가 먼 만큼 이상을 코드로 화면에 구현해 나가는 것이 어렵습니다.   
두 지점을 이어주는 다리가 비록 불안전 할지라도 시간을 들여 고쳐나가서 결국에는 두 지점이 마주하게 되면 됩니다 .   
앞으로의 밝은 C#을 바라며 Winform 기초 예제를 다루고 마치겠습니다.   
```   

**Winform Basic FileCopyApp Code**   
```ruby   
namespace FileCopyApp
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}   
```   

**<FileCopyApp>**  
   ![결과 last](/Media/WinformBasic.png "파일 복사 앱")   
   
---   

◎ 참고문서   
+ [끝나지 않는 프로그래밍 일기](https://blog.hexabrain.net/128, "Csharp basic link")   
+ [오버플로우 코드 예제](https://076923.github.io/posts/C-26/, "overflow code Exam link")   
+ [C# 배우기](https://www.csharpstudy.com/, "csharp study link")   

---
