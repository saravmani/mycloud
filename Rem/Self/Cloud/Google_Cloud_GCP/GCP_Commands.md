


echo %GOOGLE_APPLICATION_CREDENTIALS%

```
gcloud auth application-default login --impersonate-service-account memoryoverflowteam@wellsfargo-genai24-8211.iam.gserviceaccount.com
```

#### To set project
gcloud config set project wellsfargo-genai24-8211

#### To login
gcloud auth login

gcloud iam service-accounts create Sarav_Test1
gcloud projects add-iam-policy-binding wellsfargo-genai24-8211  --member="serviceAccount:Sarav_Test1@wellsfargo-genai24-8211.iam.gserviceaccount.com" --role=roles/ml.developer
