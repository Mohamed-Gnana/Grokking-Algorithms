from Common import Search as BS
ints = [1, 2, 3, 4, 5]
KeyExist = BS.BS(ints, 2)
print(KeyExist + 1)
strings = ["Ahmed", "Ali", "Mohamed", "Nahed"]
KeyExist = BS.BS(strings, "Ali")
print(KeyExist + 1)
"""errs = ["Ahmed", 1, BS(), 12.2]
KeyExist = BS.BS(errs, 12.2)
print(KeyExist + 1)"""