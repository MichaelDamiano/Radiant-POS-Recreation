import datetime

class Sale:
    global numberOfSales
    date = datetime.datetime.now()
    saleLog = {}
    location = None
    total = None
    transactionNum = None
    def __init__(self, location, quantity):
        self.location = location
        #total = quantity * item.price()
        transactionNum = numberOfSales
        numberOfSales += 1

    def addItem(self, item, quantity):
        saleLog[item] += quantity

    def removeItem(self,item, quantity):
        saleLog[item] -= quantity

