
print("He is glooby!");

def get_triangle_type():
    a = int(input('A: '))
    b = int(input('B: '))
    c = int(input('C: '))

    if a + b < c or a + c < b or b + c < a:
        print('Triangle does not exist')
    elif a == b == c:
        print('')
    elif a == b == c:
        print('')
    elif \
    a ** 2 + b ** 2 == c ** 2 or \
    a ** 2 + c ** 2 == b ** 2 or \
    c ** 2 + b ** 2 == a ** 2:
        print()
    else:
        print()

get_triangle_type()