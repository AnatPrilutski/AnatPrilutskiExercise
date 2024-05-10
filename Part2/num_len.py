from math import log10


def num_len(number: int) -> int:
    return int(log10(number)) + 1


if __name__ == '__main__':
    print("The number has", num_len(555), "digits")
