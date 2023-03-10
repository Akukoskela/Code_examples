import pandas
from scipy import stats
import numpy as np
from sklearn import preprocessing

inputfile='time_series.csv'
trainfile='train.csv'
testfile='test.csv'

data=pandas.read_csv(inputfile)

#Your code here

#print(data)

#suodatetaan koko tiedostosta vain ne tiedot jossa region on de variable wind ja attribute generation_actual
gerWindData = data[(data.region == "DE") & (data.variable == "wind")&(data.attribute =="generation_actual")]

#Poistetaan turhat sarakkeet
gerWindData.drop(gerWindData.columns[0], axis=1, inplace=True)
gerWindData.drop(gerWindData.columns[0], axis=1, inplace=True)
gerWindData.drop(gerWindData.columns[0], axis=1, inplace=True)

#poistetaan rivit joilla on määrittämättömiä arvoja
gerWindData.dropna(inplace=True)

#luodaan kynnysarvo, jonka avulla poistetaan halutun suuret poikkeamat. Tässä tapauksessa kynnys on +-4 keskiarvosta.
z_threshold=4.0

#havaitaan ja tulostetaan outlierit
z = np.abs(stats.zscore(gerWindData.data))
outlier=(z>=z_threshold)
#print('outlierit: ',gerWindData.data[outlier])

filtered_entries = (z < z_threshold)

#Poistetaan outlierit
#print('Alkuperäinen:\n',gerWindData.data)
gerWindData = gerWindData[filtered_entries]
#print('filteröity:\n',gerWindData.data)


#normalisoidaan data columnissa olevat arvot
gerWindData.data=(gerWindData.data-np.min(gerWindData.data))/(np.max(gerWindData.data)-np.min(gerWindData.data))
print('data normalisoitu:\n',gerWindData)

#luodaan testijoukko jossa on 70% datasta
train_fraction=0.7
traindata=gerWindData.sample(frac=train_fraction)
print("data shape = "+str(traindata.shape))

#luodaan opetusjoukko jossa on 30% datasta
testdata=gerWindData.drop(traindata.index)
print("data shape = "+str(testdata.shape))


#Save train data
#print("Save train data")
traindata.to_csv(trainfile)

#Save test data
#print("Save test data")
testdata.to_csv(testfile)

