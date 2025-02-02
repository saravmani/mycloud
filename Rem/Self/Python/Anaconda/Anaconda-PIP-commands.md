
```python

conda create --name poc_pythonapi python=3.12 --no-deps
conda env list # to view all env names

conda activate myenv # activate the env 
conda deactivate 



conda remove -n envname --all # remove s env and installed packages

```



### PIP


```python
pip install fastapi
pip freeze > requirements.txt # COpy dependencies to the txt file . Like pakakage.json 
```