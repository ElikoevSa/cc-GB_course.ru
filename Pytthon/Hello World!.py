import random
import pandas as pd
import numpy as np


lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI':lst})
data.head()

categories = np.unique(data['whoAmI'])
one_hot = np.zeros((len(data), len(categories)), dtype=int)
for i, cat in enumerate(categories):
    one_hot[:, i] = (data['whoAmI'] == cat).astype(int)

one_hot_df = pd.DataFrame(one_hot, columns=categories)
one_hot_df.head()