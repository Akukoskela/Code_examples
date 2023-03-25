import sys
import time
import pandas
import numpy as np
from sklearn import linear_model
from sklearn.preprocessing import PolynomialFeatures
import matplotlib.pyplot as plt

N_meas=20

inputfile='mittaus.csv'
data=pandas.read_csv(inputfile)


#eritellään  taulukosta x ja y koordinaatit ja muutetaan ne array muotoon
data_x=np.array(data.x)
data_y=np.array(data.y)

#muutetaan matriiseiksi
data_x=data_x.reshape((N_meas, 1))
data_y=data_y.reshape((N_meas, 1))


### lineaarinen regressiomalli ###

#luodaan lineaarinen regressiomalli
regr = linear_model.LinearRegression()

#opetetaan malli
regr.fit(data_x,data_y)

#ennustetaan arvot
y_estimate = regr.predict(data_x)

#luodaan kuva
fig=plt.figure(figsize=(16, 8))
plt.plot(data_x, data_y, '*')
plt.plot(data_x, y_estimate)
plt.show()

### lineaarinen regressiomalli ###

### polynominen regressiomalli ###

poly_reg=PolynomialFeatures(degree=2)

X_poly=poly_reg.fit_transform(data_x)

linreg2=linear_model.LinearRegression()
linreg2.fit(X_poly,data_y)

y_estimate2=linreg2.predict(poly_reg.fit_transform(data_x))

### polynominen regressiomalli ###

fig=plt.figure(figsize=(16, 8))
plt.plot(data_x, data_y, '.',color='black')
plt.plot(data_x, y_estimate,color='red')
plt.plot(data_x, y_estimate2,color='blue')
#plt.savefig("regression04.png")
plt.show()


#print(data)


#Your code here

#Print your solution
