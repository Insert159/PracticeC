// A. Театральная площадь

// int n=6;
// int m=6;
// int a=4;

// int i=m/a;
// int j=n/a;
// if(m!=i*a)m=a*(i+1);
// if(n!=j*a)n=a*(j+1);
// Console.WriteLine((m*n)/(a*a));

// A. Новый год: встреча друзей

// int one=7;
// int two=1;
// int three=4;
// int min=0;
// if(one>two && one>three && two<three)
// min= ((one-three)+(three-two));
// // if(one<two && one>three && two>three)
// // min= (two+three)/2;
// // if(one>two && one>three && two<three)
// // min= (one+two)/2;

// Console.WriteLine(min);



// A. Денежная система Геральдиона

int n=5;
int [] a=new int [] {1,2,3,4,5};
int count=0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i]==1) count++;
}
if (count ==0) Console.WriteLine(1);
else Console.WriteLine(-1);