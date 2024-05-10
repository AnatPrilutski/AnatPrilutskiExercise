def pythagorean_triplet_by_sum(sum: int) -> None:
    if not isinstance(sum, int):
        print("Please enter a number")
        return

    for a in range(1, sum - 1):
        for b in range(a + 1, sum - 1):
            for c in range(b + 1, sum - 1):
                if is_pythagorean_triplet(a, b, c) and (a + b + c) == sum:
                    print(f"{a}<{b}<{c}")


def is_pythagorean_triplet(a: int, b: int, c: int) -> bool:
    # a < b < c always
    if not (a ** 2) + (b ** 2) == c ** 2: return False
    return True


if __name__ == '__main__':
    pythagorean_triplet_by_sum(180)
