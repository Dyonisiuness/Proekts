import datetime


class Demon:
    def _init_(self, mythology=None, sex = True, name=None, algnment=None):
        self.mythology=mythology
        self.sex=sex
        self.name=name
        self.alignment=alignment

    def show(self):      
        if self.sex:
            str_sex="Male"
        else:
            str_sex="Female"
        return "Name - "+ str(self.name)+', Mythology - ' + str(self.mythology)\
               + ", Sex - "+ str.sex + ', alignment - ' + str(self.alignment)+";"
    def add(self):
        self.name=input("Write Name: ")
        self.alignment=input("Write alignment: ")
        self.sex=input("Write Sex(M/F): ")
        if str_sex=='F':
            self.sex=False
        else:
            self.sex=True
        self.mythology= input("Write mythology")
            
    
