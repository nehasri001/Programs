

def compareTriplets(a, b):

    # 1) Two arrays

    alice_points = 0
    bob_points = 0

    # 2)  first[0] > second[0] = point to alice,
    # first[0] < second[0] point to bob
    # else noone gets point

    for i in range(0, 3):

        if(a[i] > b[i]):
            alice_points += 1
        
        elif(a[i] < b[i]):
            bob_points += 1
        
        else:
            continue

    array = [alice_points, bob_points]

    return array

print(compareTriplets([5,6,7], [3,6,10]))
