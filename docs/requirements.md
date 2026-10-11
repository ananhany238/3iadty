## Requirements

a smart archive for medical clinics 
# Roles

Admin/Doctor: manages users, sees all patients, visits, and the audit log
Assistant: creates and edits patients and visits, approves or rejects appointment requests
Patient: views their own record and prescriptions, requests appointments

# Must-have features

Register and log in (JWT), with access limited by role
Patient CRUD (name, national ID, date of birth, phone, case category by severity)
Visits with diagnosis and notes, plus prescriptions attached to a visit
Appointments: patient requests, assistant approves or rejects, doctor sees the schedule
Audit log of create, update, and delete actions
Search, filter, and paginate patients and appointments

Out of scope for now: backups, notifications, file uploads, payments

# Business rules to write down:

A patient can only see their own data
Only an assistant or doctor can approve an appointment
Two approved appointments can’t overlap for the same doctor
