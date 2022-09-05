int num = new Random().Next(100,1000);
int a = num / 10;
int b = num / 100 * 10;
int c = a - b;
ConsoleWriteline(num + "=>" + c);
