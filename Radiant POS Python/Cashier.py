class Cashier:
    name = None
    id = None
    man = False
    shifts = []

    def __init__(self, name, id, man):
        self.name = name
        self.id = id
        self.man = man

    def makeShift(self):
        self.shifts.append('new shift')



    def toString(self):
        return "name: " + self.name + ', id: ' + self.id + ', manager:'+ self.man


#///////////////////////////////////////////////////////////////////////////////////////////////////
userInput = 55
d = {}
s = ''
inf = open("C:/Users/MaxD2/Desktop/code/cashier dictionary.txt" , 'r')
lines = inf.readlines()
for line in lines:
    words = line.split()
    d[words[2]] = Cashier(words[0] + ' ' + words[1], words[2], words[3])


while userInput != 0:
    print('beginning')
    print("1. start shift \n2. clock in/out")
    print('enter user code to start shift')
    #userInput = input()
    if d.__contains__(input()):
        print('hi')
    else:
        print('OPERATOR NOT IN DB')
        print('enter user code to start shift')


