import datetime

class Shift:
    storeID = 7742
    date = datetime.datetime.now()
    cashierName = None
    ShiftID = None
    termed = False
    sales = []

    def __init__(self, cashierName, shiftID):
        self.cashierName = cashierName
        self.shiftID = shiftID

    def makeSale(self):
        salse.append('new sale')

