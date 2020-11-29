#webserver.py

from flask import Flask
import mysql.connector

def connectdb():
    try:
        mydb = mysql.connector.connect(
            host="mysqlserver",
            user="user",
            password="pw"
        )
        return("Connection to mysqlserver ok")
    except Exception as e:
        return('Failed to connect to db: '+ str(e))



app = Flask(__name__)

@app.route('/')
def hello():
    return connectdb()

if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0', port=5000) 
