import clr
clr.AddReference(r"C:\Users\haasr\source\repos\NotifcationExample\SampleDll\bin\Debug\net6.0\SampleDll.dll")
from SampleDll import SampleClass

print("Pythonnet example")

def handler(source, args):
    print('Python event handler called!')

sC = SampleClass()

# register event handler
sC.PropertyChanged += handler
sC.Number = 1
sC.Number = sC.Number +1
print(sC.Number)

# unregister event handler
sC.PropertyChanged -= handler
sC.Number = sC.Number + 23
print(sC.Number)
print("END!")