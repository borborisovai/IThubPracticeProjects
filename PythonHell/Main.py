from flask import Flask
from markupsafe import escape

app = Flask(__name__)


@app.route("/")
def hello_world():
    return "<p>Hello, World!</p>"


@app.route("/hello")
def hello():
    return "Hello, World"


@app.post("/upload")
def upload():
    return render_template("upload.html")
