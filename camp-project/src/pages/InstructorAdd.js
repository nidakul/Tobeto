import { ErrorMessage, Field, Form, Formik } from "formik";
import React from "react";
import { Button, FormField, Label } from "semantic-ui-react";
import * as Yup from "yup";
import CampProjectTextInput from "../utilities/customFormControls/CampProjectTextInput";

export default function InstructorAdd() {
  const initialValues = {
    firstName: "",
    lastName: "",
  };
  const schema = Yup.object({
    firstName: Yup.string().required("Eğitmen adı zorunlu"),
    lastName: Yup.string().required("Eğitmen soyadı zorunlu"),
  });
  return (
      <Formik initialValues={initialValues} validationSchema={schema} onSubmit={(values) => {console.log(values);}}>
        <Form className="ui form">
          <CampProjectTextInput name="firstName" placeholder="First Name" />
          <CampProjectTextInput name="lastName" placeholder="Last Name" />
          <Button color="green" type="submit">Ekle</Button>
        </Form>
      </Formik>
  );
}