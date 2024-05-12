from math import pi


def reverse_n_pi_digits(n: int) -> str:
    return str(pi)[n::-1]


if __name__ == '__main__':
    print(reverse_n_pi_digits(6))
