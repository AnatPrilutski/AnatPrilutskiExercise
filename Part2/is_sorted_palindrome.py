from math import ceil


def is_sorted_palindrome(palindrome: str) -> bool:
    half_characters = []
    half_range = ceil(len(palindrome) / 2)
    for character in range(half_range):
        half_characters.append(palindrome[character])

    half_characters.sort()
    for character in range(half_range):
        if not palindrome[character] == half_characters[character]: return False

    if not palindrome == palindrome[::-1]: return False
    return True


if __name__ == '__main__':
    print(is_sorted_palindrome("abctcba"))
