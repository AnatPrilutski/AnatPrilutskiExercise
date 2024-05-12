def get_numbers_from_user() -> list:
    list_of_numbers = []
    number = 0
    while not number == '-1':
        number = input("Please enter a number. To finish, write -1")
        if not number == '-1':
            try:
                list_of_numbers.append(float(number))
            except ValueError:
                print("Please enter a number")

    return list_of_numbers


def print_average_of_numbers(list_of_numbers: list) -> None:
    average = 0
    for number in list_of_numbers:
        average = average + number

    print("The average of the numbers is: ", (average / (len(list_of_numbers))))


def print_positive_numbers(list_of_numbers: list) -> None:
    count = 0
    for number in list_of_numbers:
        if number > 0: count = count + 1
    print(f"The number of positive numbers in the list is: {count}")


def print_numbers_from_smallest_to_biggest(list_of_numbers: list) -> None:
    list_of_numbers.sort()
    print(f"The numbers sorted from smallest to biggest: {list_of_numbers}")


if __name__ == '__main__':
    list_of_numbers = get_numbers_from_user()
    print_average_of_numbers(list_of_numbers)
    print_positive_numbers(list_of_numbers)
    print_numbers_from_smallest_to_biggest(list_of_numbers)
