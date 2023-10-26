import cv2

img = cv2.imread("Pytthon/test.jpg")
print(img.shape)
img = cv2.resize(img, (600, 800))
print(img.shape)