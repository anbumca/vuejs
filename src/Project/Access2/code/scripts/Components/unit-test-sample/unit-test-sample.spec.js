import { shallowMount } from '@vue/test-utils'
import Hello from './unit-test-sample.vue'

test('Hello', () => {
  // render the component
  const wrapper = shallowMount(Hello)

  // should not allow for `username` less than 7 characters, excludes whitespace
  wrapper.setData({ username: 'A'.repeat(7) })

  // assert the error is rendered
  expect(wrapper.find('.error').exists()).toBe(true)

  // update the name to be long enough
  wrapper.setData({ username: 'Anbarasan' })

  // assert the error has gone away
  expect(wrapper.find('.error').exists()).toBe(true)
  expect(wrapper).toMatchSnapshot();
})