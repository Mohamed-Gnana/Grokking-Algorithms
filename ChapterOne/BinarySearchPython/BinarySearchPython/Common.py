class Search(object):
    """description of class"""
    @staticmethod
    def BS(list, key):
        low = 0
        high = len(list) - 1
        while (low <= high):
            mid = int((low + high) / 2)
            guess = list[mid]
            if (guess == key):
                return mid
            if (guess < key):
                low = mid + 1
            else:
                high = mid - 1
        return None